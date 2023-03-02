using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class EditPostParamsModel : RequestUrlParamsModel
    {
        [Description("owner_id")]
        public string OwnerId;
        [Description("message")]
        public string Message;
        [Description("attachments")]
        public string Attachments;
        [Description("post_id")]
        public string PostId;

        public EditPostParamsModel(string ownerId, string message, string attachments, string postId)
        {
            OwnerId = ownerId;
            Message = message;
            Attachments = attachments;
            PostId = postId;
        }
    }
}
