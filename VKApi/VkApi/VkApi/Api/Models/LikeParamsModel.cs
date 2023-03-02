using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class LikeParamsModel : RequestUrlParamsModel
    {
        [Description("type")]
        public string Type;
        [Description("item_id")]
        public string ItemId;
        [Description("user_id")]
        public string UserId;
        [Description("owner_id")]
        public string OwnerId;

        public LikeParamsModel(string type, string itemId, string userId, string ownerId)
        {
            Type = type;
            ItemId = itemId;
            UserId = userId;
            OwnerId = ownerId;
        }
    }
}
