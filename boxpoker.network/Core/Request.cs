using boxpoker.network.Utils;
using boxpoker.network.Session;

namespace boxpoker.network.Core
{
    public abstract class Request : IRequest
    {
        public virtual string Host => Utils.Utils.GetBaseUrl() ?? Constants.Host;

        public abstract string Path { get; }
        public abstract RequestMethod Method { get; }
        public virtual Dictionary<string, string> Header
        {
            get
            {
                var headers = new Dictionary<string, string>
                {
                    [Constants.ParamOrigin] = Utils.Utils.GetBaseUrl() ?? Constants.Api
                };
                var sessionInfo = "";
                if (sessionInfo != null && !string.IsNullOrEmpty(SessionManager.Instance.SessionObject?.AccessToken))
                {
                    headers[Constants.ParamAutorization] = $"{Constants.Bearer} {SessionManager.Instance.SessionObject?.AccessToken}";
                }

                return headers;
            }
        }

        public virtual Dictionary<string, string> QueryItem { get; }
        public virtual Dictionary<string, string> Body { get; }
        public virtual object? BodyObject { get; }
        public virtual float RequestTimeOut => 30.0f;
        public virtual bool SendRecaptcha => false;
    }

}