using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using VkApi.TestData;

namespace VkApi.PageObjects
{
    internal class MyProfilePage : Form
    {
        private ILabel AddedPostLabel(string postId) => ElementFactory.GetLabel(By.XPath($"//div[@id='post{TestingData.OwnerId}_{postId}']"), "Added post");
        private ILabel AddedCommentLabel(string commentId) => ElementFactory.GetLabel(By.XPath($"//div[@id='wpt{TestingData.OwnerId}_{commentId}']"), "Added comment");
        private ILink OpenComments(string postId) => ElementFactory.GetLink(By.XPath($"//div[contains(@class,'replies')]//a[@href='/wall{TestingData.OwnerId}_{postId}']"), "Open Comments link");
        private ILabel LikeIcon(ILabel post) => post.FindChildElement<ILabel>(By.XPath("//div[contains(@class,'PostButtonReactions__icon')]"), "Like icon");
        private ILabel GetPostLabel(ILabel post) => post.FindChildElement<ILabel>(By.XPath("//div[contains(@class,'wall_post_text')]"), "Post text");
        private ILabel GetCommentLabel(ILabel post) => post.FindChildElement<ILabel>(By.XPath("//div[contains(@class,'wall_reply_text')]"), "Comment text");
        private ILink GetPostPhoto(ILabel post, string expectedPhoto) => post.FindChildElement<ILink>(By.XPath($"//a[@href='/{expectedPhoto}']"));
        private void WaitForNewText(ILabel post, string newText) => ConditionalWait.WaitForTrue(() => post.FindChildElement<ILabel>(By.XPath("//div[contains(@class,'wall_post_text')]"), "Post new text").Text == newText);

        public MyProfilePage() : base(By.XPath("//div[contains(@class,'wall_post_text zoom_text')]"), "Post text")
        {
        }

        public string GetPostText(string postId)
        {
            GetPostLabel(AddedPostLabel(postId)).State.WaitForDisplayed();

            return GetPostLabel(AddedPostLabel(postId)).Text;
        }

        public string GetPostNewText(string newText, string postId)
        {
            WaitForNewText(AddedPostLabel(postId), newText);

            return GetPostLabel(AddedPostLabel(postId)).Text;
        }

        public bool IsPostedPhotoDisplayed(string postId, string expectedPhoto)
        {
            GetPostPhoto(AddedPostLabel(postId), expectedPhoto).State.WaitForDisplayed();

            return GetPostPhoto(AddedPostLabel(postId), expectedPhoto).State.IsDisplayed;
        }

        public string GetCommentText(string commentId)
        {
            GetCommentLabel(AddedCommentLabel(commentId)).State.WaitForDisplayed();

            return GetCommentLabel(AddedCommentLabel(commentId)).Text;
        }

        public void ClickOpenCommnetsLink(string postId) => OpenComments(postId).Click();

        public void ClickLikeIcon(string postId) =>  LikeIcon(AddedPostLabel(postId)).Click();

        public bool CheckPost(string postId)
        {
            AddedPostLabel(postId).State.WaitForNotDisplayed();

            return AddedPostLabel(postId).State.IsDisplayed;
        }
    }
}
