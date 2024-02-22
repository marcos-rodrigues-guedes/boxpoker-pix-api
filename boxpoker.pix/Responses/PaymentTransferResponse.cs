
using Newtonsoft.Json;
namespace boxpoker.pix.Response
{
    public class PaymentTransferResponse
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("body")]
        public PaymentTransferBody? Body { get; set; }
    }

    public class PaymentTransferBody
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("clientCode")]
        public string? ClientCode { get; set; }

        [JsonProperty("transactionIdentification")]
        public object? TransactionIdentification { get; set; }

        [JsonProperty("endToEndId")]
        public string? EndToEndId { get; set; }

        [JsonProperty("initiationType")]
        public string? InitiationType { get; set; }

        [JsonProperty("paymentType")]
        public string? PaymentType { get; set; }

        [JsonProperty("urgency")]
        public string? Urgency { get; set; }

        [JsonProperty("transactionType")]
        public string? TransactionType { get; set; }

        [JsonProperty("debitParty")]
        public Party? DebitParty { get; set; }

        [JsonProperty("creditParty")]
        public Party? CreditParty { get; set; }

        [JsonProperty("remittanceInformation")]
        public string? RemittanceInformation { get; set; }
    }

    public class Party
    {
        [JsonProperty("account")]
        public string? Account { get; set; }

        [JsonProperty("branch")]
        public string? Branch { get; set; }

        [JsonProperty("taxId")]
        public string? TaxId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("accountType")]
        public string? AccountType { get; set; }

        // CreditParty only properties
        [JsonProperty("bank")]
        public string? Bank { get; set; }

        [JsonProperty("key")]
        public object? Key { get; set; }
    }

}