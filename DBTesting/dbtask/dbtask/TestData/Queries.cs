using dbtask.Constants;
using System.IO;

namespace dbtask.TestData
{
    public class Queries
    {
        public static string SelectChromeAndFirefox => File.ReadAllText(FilePaths.BrowserQueryPath);
        public static string SelectMinTimeTests => File.ReadAllText(FilePaths.MinTimeQuery);
        public static string SelectUniqueTests => File.ReadAllText(FilePaths.UniqueTestsQueryPath);
        public static string SelectCompareToDate => File.ReadAllText(FilePaths.CompareToDatePath);
    }
}
