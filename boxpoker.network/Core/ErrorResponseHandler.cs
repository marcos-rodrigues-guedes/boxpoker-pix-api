using Newtonsoft.Json;

namespace boxpoker.network.Core
{
    public class ErrorResponse
    {
        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("error")]
        public ErrorDetails? Error { get; set; }
    }

    public class ErrorDetails
    {
        [JsonProperty("errorCode")]
        public string? ErrorCode { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}