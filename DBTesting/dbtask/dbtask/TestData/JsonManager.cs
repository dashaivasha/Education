using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace dbtask.TestData
{
    public class JsonManager
    {
        public static string GetTestData(string key, string path)
        {
            var json = File.ReadAllText(path);
            var data = (JObject)JsonConvert.DeserializeObject(json);
            var result = data[key].Value<string>();

            return result;
        }
    }
}
