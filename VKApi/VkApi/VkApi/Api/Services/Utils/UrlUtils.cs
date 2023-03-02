using System.Collections.Generic;
using System.Web;

namespace VkApi.Api.Services.Utils
{
    public class UrlUtils
    {
        public static string ConstructUrl(Dictionary<string, string> urlParams)
        {
            System.Collections.Specialized.NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);

            foreach (KeyValuePair<string, string> item in urlParams)
            {
                query[item.Key] = item.Value;
            }

            return query.ToString();
        }
    }
}