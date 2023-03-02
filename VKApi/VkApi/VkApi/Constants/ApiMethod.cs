using System.ComponentModel;

namespace VkApi.Constants
{
    public enum ApiMethod
    {
        [Description("wall.post")]
        wallPost,
        [Description("wall.edit")]
        wallEdit,
        [Description("wall.createComment")]
        wallCreateComment,
        [Description("likes.isLiked")]
        likesIsLiked,
        [Description("wall.delete")]
        wallDelete,
        [Description("photos.getWallUploadServer")]
        photoGetWallUploadServer,
        [Description("photos.saveWallPhoto")]
        photosSaveWallPhoto
    }
}
