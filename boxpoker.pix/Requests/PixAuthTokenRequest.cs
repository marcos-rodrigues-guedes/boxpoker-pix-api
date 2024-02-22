using boxpoker.network.Core;

namespace boxpoker.pix.Requests
{
    public class PixAuthTokenRequest : Request
    {
        public override string Path => "/token";

        public override RequestMethod Method => RequestMethod.Post;
    }
}