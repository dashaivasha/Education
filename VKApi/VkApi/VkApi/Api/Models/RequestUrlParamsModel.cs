using System.ComponentModel;
using VkApi.TestData;
using static VkApi.Constants.Keys;

namespace VkApi.Api.Models
{
    public abstract class RequestUrlParamsModel
    {
        [Description("access_token")]
        public string AccessToken;
        [Description("v")]
        public string Version;

        protected RequestUrlParamsModel()
        {
            AccessToken = TestingData.AccessToken; 
            Version = TestingData.ApiVkVersion;
        }
    }
}
