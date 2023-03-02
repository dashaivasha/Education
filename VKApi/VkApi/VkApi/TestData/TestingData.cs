using VkApi.Constants;
using static VkApi.Constants.Keys;

namespace VkApi.TestData
{
    public class TestingData
    {
        public static string OwnerId => JsonManager.GetTestData(DataKey.owner_id.GetEnumDescription(), FilePaths.DataPath);
        public static string Url => JsonManager.GetTestData(DataKey.Url.GetEnumDescription(), FilePaths.DataPath);
        public static string Login => JsonManager.GetTestData(DataKey.Login.GetEnumDescription(), FilePaths.CredentialsPath);
        public static string Password => JsonManager.GetTestData(DataKey.Password.GetEnumDescription(), FilePaths.CredentialsPath);
        public static string AccessToken => JsonManager.GetTestData(DataKey.Access_token.GetEnumDescription(), FilePaths.DataPath);
        public static string ApiVkVersion => JsonManager.GetTestData(DataKey.ApiVkVersion.GetEnumDescription(), FilePaths.DataPath);
        public static string ApiAddress => JsonManager.GetTestData(DataKey.ApiAddress.GetEnumDescription(), FilePaths.DataPath);
        public static string RandomStringLength => JsonManager.GetTestData(DataKey.RandomStringLength.GetEnumDescription(), FilePaths.DataPath);
        public static string PostPhoto => JsonManager.GetTestData(DataKey.PostPhoto.GetEnumDescription(), FilePaths.DataPath);
        public static string ObjectType => JsonManager.GetTestData(DataKey.ObjectType.GetEnumDescription(), FilePaths.DataPath);
    }
}
