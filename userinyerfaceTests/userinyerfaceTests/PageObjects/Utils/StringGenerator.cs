using System;
using System.Text;
using userinyerfaceTests.TestData;
using static userinyerfaceTests.Constants.Keys;

namespace userinyerfaceTests.PageObjects.Utils
{
    internal static class StringGenerator
    {
        private static Random random = new Random();
        private const string cyrillicCharacters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string password = cyrillicCharacters;
        private const int shiftIntervalData = 25;
        private const int charsIndex = 65;
        public static string Generate(int length)
        {
            StringBuilder strBuild = new StringBuilder();
            GeneratePartOfRandomString(length, strBuild);
            var сyrillicCharindex = random.Next(cyrillicCharacters.Length);
            var сyrillicChar = cyrillicCharacters[сyrillicCharindex];
            strBuild.Append(сyrillicChar);
            var num = random.Next(1, 9);
            strBuild.Append(num.ToString());
            var sameSymbol = password[0];
            strBuild.Append(sameSymbol);

            return strBuild.ToString();
        }

        private static string GeneratePartOfRandomString(int length, StringBuilder str_build)
        {
            for (int i = 1; i < length - 2; i++)
            {
                var flt = random.NextDouble();
                var shift = Convert.ToInt32(Math.Floor(shiftIntervalData * flt));
                var letter = Convert.ToChar(shift + charsIndex);
                str_build.Append(letter);
            }

            return str_build.ToString();
        }
    }
}
