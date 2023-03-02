using System;
using System.IO;

namespace userinyerfaceTests.Constants
{
    static class FilePaths
    {
        public static readonly string _projectDirectory = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string DataPath = Path.Combine("TestData", "Resources", "TestData.json");
        public static readonly string PhotoAvatar = Path.Combine("TestData", "Resources", "Avatar.JPG");
    }
}
 