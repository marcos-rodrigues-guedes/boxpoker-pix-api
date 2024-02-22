namespace boxpoker.network.Core
{
    internal class AuthPixRequest : Request
    {
        public override string Path => "/v5/token";

        public override RequestMethod Method => RequestMethod.Post;

        public override Dictionary<string, string> Body
        {
            get
            {
                var bodyData = new Dictionary<string, string>
                {
                    { "client_id", Utils.Utils.GetClientID() },
                    { "grant_type", Utils.Utils.GetGrantType() },
                    { "client_secret", Utils.Utils.GetClientSecret() }
                };
                return bodyData;
            }
        }
    }
}

