using System;
using System.Net.Http;
using VkApi.Api.Client;
using VkApi.TestData;
using static VkApi.Constants.Keys;

namespace VkApi.Api.Services
{
    public class Service
    {
        private protected HttpClient _httpClient = HttpClientFactory.GetHttpClient();

        public Service()
        {

            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri(TestingData.ApiAddress);
            }

            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
    }
}
