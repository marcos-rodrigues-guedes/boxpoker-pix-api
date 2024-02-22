using Newtonsoft.Json;

namespace boxpoker.pix.Response
{

    public class DynamicQRCodeResponse
    {
        public string? Version { get; set; }
        public int Status { get; set; }
        public Body? Body { get; set; }
    }

    public class Body
    {
        public string? ClientRequestId { get; set; }
        public object? PactualId { get; set; }
        public string? TransactionId { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
        public string? Entity { get; set; }
        public string? Status { get; set; }
        public object? Tags { get; set; }
        public string? TransactionIdentification { get; set; }

        [JsonProperty("body")]
        public BodyData? BodyData { get; set; }
    }

    public class BodyData
    {
        public string? Key { get; set; }
        public string? Revision { get; set; }
        public string? Location { get; set; }
        public Debtor? Debtor { get; set; }
        public Amount? Amount { get; set; }
        public Calendar? Calendar { get; set; }
        public DynamicBRCodeData? DynamicBRCodeData { get; set; }
        public object? AdditionalInformation { get; set; }
    }

    public class Debtor
    {
        public string? Name { get; set; }
        public object? Cpf { get; set; }
        public object? Cnpj { get; set; }
    }

    public class Amount
    {
        public string? Original { get; set; }
    }

    public class Calendar
    {
        public int Expiration { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class DynamicBRCodeData
    {
        public string? PointOfInitiationMethod { get; set; }
        public string? PayloadFormatIndicator { get; set; }
        public string? CountryCode { get; set; }
        public string? MerchantName { get; set; }
        public string? MerchantCity { get; set; }
        public string? TransactionIdentification { get; set; }
        public string? TransactionAmount { get; set; }
        public string? Emvqrcps { get; set; }
        public int MerchantCategoryCode { get; set; }
        public int TransactionCurrency { get; set; }
        public MerchantAccountInformation? MerchantAccountInformation { get; set; }
    }

    public class MerchantAccountInformation
    {
        public string? Url { get; set; }
    }
}