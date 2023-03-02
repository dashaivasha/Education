using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class PostUrlParamsModel : RequestUrlParamsModel
    {
        [Description("owner_id")]
        public string OwnerId;
        [Description("message")]
        public string Message;
        [Description("attachments")]
        public string Attachments;
    }
}