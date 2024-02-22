using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace boxpoker.network.Core
{

    public class HttpHelper : IHttpHelper
    {
        private readonly HttpClient _httpClient;

        private readonly HttpClientHandler _httpClientHandler;

        private readonly TokenValidationHandler? _tokenValidationHandler;

        public HttpHelper()
        {
            _httpClientHandler = new();

            _tokenValidationHandler = new()
            {
                InnerHandler = _httpClientHandler
            };
            _httpClient = new HttpClient(_tokenValidationHandler);
            
        }

        public async Task<T> Request<T>(IRequest req, bool isAuth = false) where T : class
        {
            if (!Uri.TryCreate(req.Host + req.Path, UriKind.Absolute, out var uri))
            {
                throw new ArgumentException("Invalid URL");
            }

            var request = isAuth ? ConfigureMultipartFormDataRequest(req, uri) : ConfigureHttpRequest(req, uri);

            var response = await _httpClient.SendAsync(request);

            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                try
                {
                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseBody);
                    var errorMessage = errorResponse?.Error?.Message ?? "Unknown error";
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode} and message: {errorMessage}");
                }
                catch (JsonException ex)
                {
                    // Se a deserialização falhar, lance uma exceção genérica
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode} and could not parse error response: {ex.Message}", ex);
                }
            }

            try
            {
                // Attempt to deserialize the response body into the specified type
                var result = JsonConvert.DeserializeObject<T>(responseBody);
                return result;
            }
            catch (System.Text.Json.JsonException ex)
            {
                // Handle JSON deserialization error
                throw new Exception($"Failed to deserialize JSON response: {ex.Message}", ex);
            }
        }

        private static HttpRequestMessage ConfigureHttpRequest(IRequest req, Uri uri)
        {
            var request = new HttpRequestMessage(new HttpMethod(req.Method.ToString()), uri);

            if (req.Header != null)
            {
                foreach (var (key, value) in req.Header)
                {
                    request.Headers.Add(key, value);
                }
            }

            if (req.BodyObject != null)
            {
                var json = JsonConvert.SerializeObject(req.BodyObject);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            if (req.QueryItem != null)
            {
                var queryBuilder = new StringBuilder();
                foreach (var (key, value) in req.QueryItem)
                {
                    queryBuilder.Append($"{WebUtility.UrlEncode(key)}={WebUtility.UrlEncode(value)}&");
                }
                var queryString = queryBuilder.ToString().TrimEnd('&');
                uri = new Uri($"{uri}?{queryString}");
            }

            return request;
        }

        private static HttpRequestMessage ConfigureMultipartFormDataRequest(IRequest req, Uri uri)
        {
            var formDataContent = new MultipartFormDataContent();

            foreach (var (key, value) in req.Body)
            {
                formDataContent.Add(new StringContent(value), key);
            }

            var request = new HttpRequestMessage(HttpMethod.Post, uri)
            {
                Content = formDataContent
            };

            request.Headers.Add("accept", "application/json");

            return request;
        }

    }

}