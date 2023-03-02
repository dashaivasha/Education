using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using VkApi.Api.Models;
using VkApi.Api.Models.ResponseModels;
using VkApi.Constants;

namespace VkApi.TestData
{
    public class JsonManager
    {
        public static string GetTestData(string key, string path)
        {
            var json = File.ReadAllText(path);
            var data = (JObject)JsonConvert.DeserializeObject(json);
            var result = data[key].Value<string>();

            return result;
        }

        public static PostResponse GetResposeBody(string result)
        {
            PostResponse response = JsonConvert.DeserializeObject<PostResponse>(result);

            return response;
        }

        public static CommentResponse GetCommentResposeBody(string result)
        {
            CommentResponse response = JsonConvert.DeserializeObject<CommentResponse>(result);

            return response;
        }

        public static LikeResponse GetIsLikedResposeBody(string result)
        {
            LikeResponse response = JsonConvert.DeserializeObject<LikeResponse>(result);

            return response;
        }

        public static DeleteResponse GetDeleteResposeBody(string result)
        {
            DeleteResponse response = JsonConvert.DeserializeObject<DeleteResponse>(result);

            return response;
        }

        public static UploadServerResponseModel GetUploadServereResposeBody(string result)
        {
            UploadServerResponseModel response = JsonConvert.DeserializeObject<UploadServerResponseModel>(result);

            return response;
        }

        public static UploadPhotoResponse GetUploadPhotoResponseBody(string result)
        {
            UploadPhotoResponse response = JsonConvert.DeserializeObject<UploadPhotoResponse>(result);

            return response;
        }

        public static SaveResponseModel GetSaveResponseModeleBody(string result)
        {
            SaveResponseModel response = JsonConvert.DeserializeObject<SaveResponseModel>(result);

            return response;
        }
    }
}
