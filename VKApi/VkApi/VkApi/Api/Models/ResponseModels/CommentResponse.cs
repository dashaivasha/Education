namespace VkApi.Api.Models
{
    public class CommentResponse
    {
        public Response response { get; set; }

        public class Response
        {
            public string Comment_id { get; set; }
            public object[] parents_stack { get; set; }
        }
    }
}
