namespace VkApi.Api.Models.ResponseModels
{
    public class SaveResponseModel
    {
        public Response[] response { get; set; }

        public class Response
        {
            public int Album_id { get; set; }
            public int Date { get; set; }
            public int Id { get; set; }
            public int Owner_id { get; set; }
            public string Access_key { get; set; }
            public Size[] Sizes { get; set; }
            public string Text { get; set; }
            public bool Has_tags { get; set; }
        }

        public class Size
        {
            public int height { get; set; }
            public string url { get; set; }
            public string type { get; set; }
            public int width { get; set; }
        }
    }
}
