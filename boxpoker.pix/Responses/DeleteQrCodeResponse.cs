using Newtonsoft.Json;

namespace boxpoker.pix.Response
{
    public class DeleteQrCodeResponse
	{
        [JsonProperty("transactionId")]
        public decimal TransactionId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
