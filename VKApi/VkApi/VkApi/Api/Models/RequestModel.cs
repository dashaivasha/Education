namespace VkApi.Api.Models
{
    public class RequestModel
    {
        public string Method;
        public RequestUrlParamsModel RequestUrlParams;
        public RequestModel(string method, RequestUrlParamsModel requestUrlParams)
        {
            Method = method;
            RequestUrlParams = requestUrlParams;
        }
    }
}
