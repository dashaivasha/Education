using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class SavePhotoModel : RequestUrlParamsModel
    {
        [Description("user_id")]
        public string UserId;
        [Description("group_id")]
        public string GroupId;
        [Description("photo")]
        public string Photo;
        [Description("server")]
        public string Server;
        [Description("hash")]
        public string Hash;

        public SavePhotoModel(string userId, string groupId, string photo, string server, string hash)
        {
            UserId = userId;
            GroupId = groupId;
            Photo = photo;
            Server = server;
            Hash = hash;
        }
    }
}
