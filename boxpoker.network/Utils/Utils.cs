using Microsoft.Extensions.Configuration;

namespace boxpoker.network.Utils
{
    public static class Utils
    {
        private static readonly IConfigurationRoot _config;

        static Utils()
        {
            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string GetBaseUrl()
        {
            return _config.GetSection("PixProviderSettings")["base_url"] ?? "";
        }

        public static string GetClientID()
        {
            return _config.GetSection("PixProviderSettings")["client_id"] ?? "";
        }

        public static string GetGrantType()
        {
            return _config.GetSection("PixProviderSettings")["grant_type"] ?? "";
        }

        public static string GetClientSecret()
        {
            return _config.GetSection("PixProviderSettings")["client_secret"] ?? "";
        }
    }
}