using boxpoker.network.Core;
using boxpoker.network.Session;

namespace boxpoker.network.Repository
{
    public class NetworkRepository : INetworkRepository
    {
		
        public async Task<AuthResponse> GetAuthPixToken()
        {
            var request = new AuthPixRequest();
            var req = new HttpHelper();
            var response = await req.Request<AuthResponse>(request, true);
            SessionManager.Instance.SessionObject = response;
            return response;
        }
    }
}