namespace boxpoker.network.Core
{
    public class HttpHelperManager
	{
        private static HttpHelperManager? _instance;

        private HttpHelper? _httpHelper;

        private HttpHelperManager()
		{
            _httpHelper = new HttpHelper();
		}

        public static HttpHelperManager Instance
        {
            get
            {
                _instance ??= new HttpHelperManager();
                return _instance;
            }
        }

        public HttpHelper? HttpHelper
        {
            get
            {
                return _httpHelper;
            }
            set
            {
                _httpHelper = value;
            }
        }

    }
}