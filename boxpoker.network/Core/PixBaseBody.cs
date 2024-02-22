using Newtonsoft.Json;

namespace boxpoker.network.Core
{
    public abstract class PixBaseBody
	{
        [JsonProperty("clientRequestId")]
        public virtual string ClientRequestId => Guid.NewGuid().ToString();

        [JsonProperty("key")]
        public abstract string Key { get; }

        [JsonProperty("merchant")]
        public abstract Merchant Merchant { get; }


}

    public abstract class Merchant
    {

        [JsonProperty("postalCode")]
        public virtual string PostalCode => "78803040";

        [JsonProperty("city")]
        public virtual string City => "Araguaina";

        [JsonProperty("merchantCategoryCode")]
        public virtual string MerchantCategoryCode => "5651";

        [JsonProperty("name")]
        public virtual string Name => "BoxPoker Finance";

    }
}
