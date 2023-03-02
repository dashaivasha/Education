using System.Net.Http;

namespace VkApi.Api.Client
{
    public class HttpClientFactory
    {
        private static HttpClient? _httpClient;

        public static HttpClient GetHttpClient()
        {
            if (_httpClient == null)
            {
                _httpClient = new HttpClient();
            }
            return _httpClient;
        }
    }
}
