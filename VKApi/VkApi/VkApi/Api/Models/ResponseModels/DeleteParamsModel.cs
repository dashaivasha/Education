using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class DeleteParamsModel : RequestUrlParamsModel
    {
        [Description("post_id")]
        public string PostId;
        [Description("owner_id")]
        public string OwnerId;

        public DeleteParamsModel(string postId, string ownerId)
        {
            PostId = postId;
            OwnerId = ownerId;
        }
    }
}
