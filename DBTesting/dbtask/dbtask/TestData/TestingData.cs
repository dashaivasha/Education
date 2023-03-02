using dbtask.Constants;
using static dbtask.Constants.Keys;

namespace dbtask.TestData
{
    public class TestingData
    {
        public static string Login => JsonManager.GetTestData(DataKey.Login.GetEnumDescription(), FilePaths.CredentialsPath);
        public static string Password => JsonManager.GetTestData(DataKey.Password.GetEnumDescription(), FilePaths.CredentialsPath);
        public static string Server => JsonManager.GetTestData(DataKey.Server.GetEnumDescription(), FilePaths.DataPath);
        public static string DbName => JsonManager.GetTestData(DataKey.DBName.GetEnumDescription(), FilePaths.DataPath);
    }
}
