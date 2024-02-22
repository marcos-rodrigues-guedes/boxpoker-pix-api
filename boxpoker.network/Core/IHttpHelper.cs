namespace boxpoker.network.Core
{
    public interface IHttpHelper
	{
        Task<T> Request<T>(IRequest req, bool isAuth = false) where T : class;
    }
}