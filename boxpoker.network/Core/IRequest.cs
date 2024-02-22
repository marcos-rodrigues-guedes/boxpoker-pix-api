namespace boxpoker.network.Core
{
    public interface IRequest
	{
        string Host { get; }
        string Path { get; }
        RequestMethod Method { get; }
        Dictionary<string, string> Header { get; }
        Dictionary<string, string> QueryItem { get; }
        Dictionary<string, string> Body { get; }
        object BodyObject { get; }
        float RequestTimeOut { get; }
        bool SendRecaptcha { get; }
    }
}