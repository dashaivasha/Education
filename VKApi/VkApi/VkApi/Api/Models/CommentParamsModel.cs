using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class CommentParamsModel : RequestUrlParamsModel
    {
        [Description("post_id")]
        public string PostId;
        [Description("owner_id")]
        public string OwnerId;
        [Description("message")]
        public string Message;

        public CommentParamsModel(string postId, string ownerId, string message)
        {
            PostId = postId;
            OwnerId = ownerId;
            Message = message;
        }
    }
}
