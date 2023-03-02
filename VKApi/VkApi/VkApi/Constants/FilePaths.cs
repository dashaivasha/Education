using System.IO;

namespace VkApi.Constants
{
    static class FilePaths
    {
        public static readonly string _projectDirectory = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string CredentialsPath = Path.Combine("TestData", "Resources", "Credentials.json");
        public static readonly string DataPath = Path.Combine("TestData", "Resources", "TestData.json");
        public static readonly string PhotoPath = Path.Combine("TestData", "Resources", "cat.jpg");
    }
}
