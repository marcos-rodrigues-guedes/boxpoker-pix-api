using Newtonsoft.Json;

namespace boxpoker.pix.Responses
{
	public class PixTransactionsStatusResponse
    {
		
            [JsonProperty("transactionId")]
            public int TransactionId { get; set; }

            [JsonProperty("clientCode")]
            public string? ClientCode { get; set; }

            [JsonProperty("endToEndId")]
            public string? EndToEndId { get; set; }

            [JsonProperty("status")]
            public string? Status { get; set; }

            [JsonProperty("error")]
            public string? Error { get; set; }
        
	}
}