using NUnit.Framework;
using System;
using VkApi.Api.Models;
using VkApi.Base;
using VkApi.TestData;
using VkApi.TestData.Utilities;

namespace VkApi.UITests
{

    [TestFixture]
    public class VkTests : BaseTest
    {

        [Test]
        public void VKApiAsync()
        {
            authorizationForm.EnterLoginFromTestData();
            authorizationForm.ClickSignInButton();
            passwordForm.EnterPassword();
            passwordForm.ClickContinueButton();
            menuForm.ClickMyProfileLink();
            PostResponse response = postService.PostPostModelAsync(postToPost).Result;
            Assert.AreEqual(postToPost.Message, myProfile.GetPostText(response.Response.Post_id), "The post on the wall does not match the expected result");

            var photoData = $"{TestingData.PostPhoto}{postToPost.OwnerId}_{photoModel.response[0].Id}";
            EditPostParamsModel postToEdit = new(postToPost.OwnerId, StringGenerator.RandomString(), photoData, response.Response.Post_id);
            postService.EditPostModelAsync(postToEdit);
            Assert.AreEqual(postToEdit.Message, myProfile.GetPostNewText(postToEdit.Message, postToEdit.PostId), "The new text on the wall does not match the expected result");
            Assert.IsTrue(myProfile.IsPostedPhotoDisplayed(postToEdit.PostId, photoData), "The picture is not displayed for the selected post id");

            CommentParamsModel comment = new(postToEdit.PostId, postToPost.OwnerId, StringGenerator.RandomString());
            CommentResponse commentResponse = postService.CreateCommentAsync(comment).Result;
            myProfile.ClickOpenCommnetsLink(postToEdit.PostId);
            Assert.AreEqual(comment.Message, myProfile.GetCommentText(commentResponse.response.Comment_id), "The comment text does not match the expected text");

            myProfile.ClickLikeIcon(postToEdit.PostId);
            LikeParamsModel isLikedModel = new(TestingData.ObjectType, postToEdit.PostId, postToPost.OwnerId, postToPost.OwnerId);
            LikeResponse isLikedResponse = postService.IsLikedAsync(isLikedModel).Result;
            var isLiked = Convert.ToBoolean(Convert.ToInt16(isLikedResponse.response.Liked));
            Assert.IsTrue(isLiked, "The post does not have a like on it");

            DeleteParamsModel deleteModel = new(postToEdit.PostId, postToPost.OwnerId);
            postService.DeletePostAsync(deleteModel);
            Assert.IsFalse(myProfile.CheckPost(postToEdit.PostId), "The post was not deleted and is still being displayed");
        }
    }
}


