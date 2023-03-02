using System.ComponentModel;

namespace VkApi.Api.Models
{
    public class UploadServerModel : RequestUrlParamsModel
    {
        [Description("group_id")]
        public string GroupId;

        public UploadServerModel(string groupId)
        {
            GroupId = groupId;
        }
    }
}
