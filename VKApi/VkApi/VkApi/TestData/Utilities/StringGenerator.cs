using System;
using System.Linq;
using static VkApi.Constants.Keys;

namespace VkApi.TestData.Utilities
{
    internal class StringGenerator
    {
        private static Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string RandomString()
        {
            var length = Convert.ToInt32(TestingData.RandomStringLength);
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
