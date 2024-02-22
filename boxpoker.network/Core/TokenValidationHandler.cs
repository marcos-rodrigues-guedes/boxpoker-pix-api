using boxpoker.network.Session;
using boxpoker.network.Utils;

namespace boxpoker.network.Core
{
    public class TokenValidationHandler : DelegatingHandler
	{
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine(request);
            
            // Verifica se o token é válido antes de prosseguir com a requisição
            if (!SessionManager.Instance.IsTokenValid() && ((!request.RequestUri?.OriginalString.Contains("token")) ?? false))
            {
              
                if (HttpHelperManager.Instance.HttpHelper != null)
                {
                    var response = await HttpHelperManager.Instance.HttpHelper.Request<AuthResponse>(new AuthPixRequest(), true);
                    SessionManager.Instance.SessionObject = response;
                    request.Headers.Add(Constants.ParamAutorization, $"{Constants.Bearer} {SessionManager.Instance.SessionObject?.AccessToken}");
                }
            }

            // Se o token for válido, prossegue com a requisição
            var resp = await base.SendAsync(request, cancellationToken);

            Console.WriteLine(resp);

            return resp;
        }
    }
}

