using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using userinyerfaceTests.Constants;

namespace userinyerfaceTests.TestData
{
    public class JsonManager
    {
        public static string GetTestData(string key)
        {
            var json = File.ReadAllText(FilePaths.DataPath);
            var data = (JObject)JsonConvert.DeserializeObject(json);
            var result = data[key].Value<string>();

            return result;
        }
    }
}
