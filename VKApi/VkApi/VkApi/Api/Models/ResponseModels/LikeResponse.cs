namespace VkApi.Api.Models
{
    public class LikeResponse
    {
        public Response response { get; set; }

        public class Response
        {
            public int Liked { get; set; }
            public int Copied { get; set; }
        }

    }
}
