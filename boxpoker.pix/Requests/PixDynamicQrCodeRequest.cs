using System.ComponentModel;
using boxpoker.network.Core;
using Newtonsoft.Json;

namespace boxpoker.pix.Requests
{
    public class PixDynamicQrCodeRequest : Request
	{
        public string? PixKey;

        public string? Amount;

        public string? PayerName;

        public string? PayerCPF;

        public string? PayerCNPJ;

        public override string Path => "/pix/v1/brcode/dynamic";

        public override RequestMethod Method => RequestMethod.Post;

        public override object? BodyObject => new QrCodeBody(PixKey, Amount, PayerName, PayerCPF, PayerCNPJ);

    }

    internal class QrCodeBody : PixBaseBody
    {
        private readonly string? _key;
        private readonly string? _amount;
        private readonly string? _payerName;
        private readonly string? _payerCPF;
        private readonly string? _payerCNPJ;

        public QrCodeBody(
            string? key,
            string? amount,
            string? payerName,
            string?  payerCPF,
            string?  payerCNPJ
        )
        {
            _key = key;
            _amount = amount;
            _payerName = payerName;
            _payerCPF = payerCPF;
            _payerCNPJ = payerCNPJ;
        }

        [JsonProperty("key")]
        public override string Key => _key ?? "";

        [JsonProperty("amount")]
        public string? Amount => _amount;

        [JsonProperty("payerName")]
        public string? PayerName => _payerName;

        [JsonProperty("payerCPF")]
        public string? PayerCPF => _payerCPF;

        [JsonProperty("payerCNPJ")]
        public string? PayerCNPJ => _payerCNPJ;

        public override Merchant Merchant => new QRcodeMerchant();

        
    }

    internal class QRcodeMerchant : Merchant
    {

    }
}


