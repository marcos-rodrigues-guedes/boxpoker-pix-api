using Newtonsoft.Json;

namespace boxpoker.pix.Response
{

    public class PixKeyInformationResponse
    {
        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("keyType")]
        public string? KeyType { get; set; }

        [JsonProperty("account")]
        public Account? Account { get; set; }

        [JsonProperty("owner")]
        public Owner? Owner { get; set; }

        [JsonProperty("endtoendid")]
        public string? EndToEndId { get; set; }

        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("keyOwnershipDate")]
        public DateTime KeyOwnershipDate { get; set; }

        [JsonProperty("responseTime")]
        public DateTime ResponseTime { get; set; }

        [JsonProperty("openClaimCreationDate")]
        public object? OpenClaimCreationDate { get; set; }

        [JsonProperty("statistics")]
        public Statistics? Statistics { get; set; }
    }

    public class Account
    {
        [JsonProperty("openingDate")]
        public DateTime OpeningDate { get; set; }

        [JsonProperty("participant")]
        public string? Participant { get; set; }

        [JsonProperty("branch")]
        public int Branch { get; set; }

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("accountType")]
        public string? AccountType { get; set; }
    }

    public class Owner
    {
        [JsonProperty("taxIdNumber")]
        public string? TaxIdNumber { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("tradeName")]
        public string? TradeName { get; set; }
    }

    public class Statistics
    {
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("counters")]
        public List<Counter>? Counters { get; set; }
    }

    public class Counter
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("by")]
        public string? By { get; set; }

        [JsonProperty("d3")]
        public string? D3 { get; set; }

        [JsonProperty("d30")]
        public string? D30 { get; set; }

        [JsonProperty("m6")]
        public string? M6 { get; set; }
    }
}