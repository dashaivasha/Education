using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace VkApi.Api.Services.Utils
{
    internal static class RequestUrlParamsModelParser
    {
        public static Dictionary<string, string> Parse<T>(T model)
        {
           return model.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance)
              .Where(f => f.GetValue(model) != null)
              .ToDictionary(f => f.GetCustomAttribute<DescriptionAttribute>().Description, f => (string)f.GetValue(model));
        }
    }
}
