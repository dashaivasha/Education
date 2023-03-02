namespace VkApi.Api.Models
{
    public class UploadServerResponseModel
    {
        public Response response { get; set; }
        public class Response
        {
            public string Album_id { get; set; }
            public string Upload_url { get; set; }
            public string User_id { get; set; }
        }
    }
}
