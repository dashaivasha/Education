using System.IO;

namespace dbtask.Constants
{
    static class FilePaths
    {
        public static readonly string _projectDirectory = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string CredentialsPath = Path.Combine("TestData", "Resources", "Credentials.json");
        public static readonly string DataPath = Path.Combine("TestData", "Resources", "TestData.json");
        public static readonly string BrowserQueryPath = Path.Combine("TestData", "Resources", "BrowserQuery.sql");
        public static readonly string UniqueTestsQueryPath = Path.Combine("TestData", "Resources", "UniqueTestsQuery.sql");
        public static readonly string MinTimeQuery = Path.Combine("TestData", "Resources", "MinTimeQuery.sql");
        public static readonly string CompareToDatePath = Path.Combine("TestData", "Resources", "CompareToDateQuery.sql");

    }
}
