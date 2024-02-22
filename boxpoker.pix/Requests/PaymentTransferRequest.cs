using boxpoker.network.Core;
using Newtonsoft.Json;

namespace boxpoker.pix.Requests
{
    public class PaymentTransferRequest : Request
    {
        public required string Amount;

        public required string ClientCode;

        public required string EndToEndId;

        public required string InitiationType;

        public required string PaymentType;

        public required string Urgency;

        public required string TransactionType;

        public required string DebitAccount;

        public required string CreditAccount;

        public required string Bank;

        public required string Key;

        public required string Branch;

        public required string TaxId;

        public required string Name;

        public required string AccountType;

        public required string RemittanceInformation;

        public override string Path => "/baas-wallet-transactions-webservice/v1/pix/payment";

        public override RequestMethod Method => RequestMethod.Post;

        public override object? BodyObject => new BodyPaymentTransfer
        {
            Amount = Amount,
            ClientCode = ClientCode,
            EndToEndId = EndToEndId,
            InitiationType = InitiationType,
            PaymentType = PaymentType,
            Urgency = Urgency,
            TransactionType = TransactionType,
            DebitParty = new DebitParty
            {
                Account = DebitAccount,

            },
            CreditParty = new CreditParty {
                Account = CreditAccount,
                Bank = Bank,
                Key = Key,
                Branch = Branch,
                TaxId = TaxId,
                Name = Name,
                AccountType = AccountType
            },
            RemittanceInformation = RemittanceInformation
        };
    }

    internal class BodyPaymentTransfer
    {
        [JsonProperty("amount")]
        public required string Amount { get; set; }

        [JsonProperty("clientCode")]
        public required string ClientCode { get; set; }

        [JsonProperty("endToEndId")]
        public required string EndToEndId { get; set; }

        [JsonProperty("initiationType")]
        public required string InitiationType { get; set; }

        [JsonProperty("paymentType")]
        public required string PaymentType { get; set; }

        [JsonProperty("urgency")]
        public required string Urgency { get; set; }

        [JsonProperty("transactionType")]
        public required string TransactionType { get; set; }

        [JsonProperty("debitParty")]
        public required DebitParty DebitParty { get; set; }

        [JsonProperty("creditParty")]
        public required CreditParty CreditParty { get; set; }

        [JsonProperty("remittanceInformation")]
        public required string RemittanceInformation { get; set; }
    }

    internal class DebitParty
    {
        [JsonProperty("account")]
        public required string Account { get; set; }
    }

    internal class CreditParty
    {
        [JsonProperty("bank")]
        public required string Bank { get; set; }

        [JsonProperty("key")]
        public required string Key { get; set; }

        [JsonProperty("account")]
        public required string Account { get; set; }

        [JsonProperty("branch")]
        public required string Branch { get; set; }

        [JsonProperty("taxId")]
        public required string TaxId { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("accountType")]
        public required string AccountType { get; set; }
    }
}