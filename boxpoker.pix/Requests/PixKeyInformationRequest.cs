using Newtonsoft.Json;
using boxpoker.network.Core;

namespace boxpoker.pix.Requests
{
    public class PixKeyInformationRequest : Request
    {
        public required string PixKey;

        public required string PayerId;

        public override string Path => "/pix/v1/dict/v2/key";

        public override RequestMethod Method => RequestMethod.Post;

        public override object? BodyObject => new Body(PixKey, PayerId);
    }

    internal class Body {

        private readonly string? _key;

        private readonly string? _payerId;

        public Body(string key, string payerId)
        {
            _key = key;
            _payerId = payerId;
        }

        [JsonProperty("key")]
        public string Key => _key ?? "";

        [JsonProperty("payerId")]
        public string PayerId => _payerId ?? "";
    } 
}