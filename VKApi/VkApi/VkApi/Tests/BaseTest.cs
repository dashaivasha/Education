using Aquality.Selenium.Browsers;
using NUnit.Framework;
using VkApi.Api.Models;
using VkApi.Api.Models.ResponseModels;
using VkApi.Api.Services;
using VkApi.PageObjects;
using VkApi.PageObjects.Forms;
using VkApi.TestData;
using VkApi.TestData.Utilities;

namespace VkApi.Base
{
    public abstract class BaseTest
    {
        private AuthorizationForm? _authorizationForm;
        private protected AuthorizationForm authorizationForm => _authorizationForm ??= new AuthorizationForm();
        private PasswordForm? _passwordForm;
        private protected PasswordForm passwordForm => _passwordForm ??= new PasswordForm();
        private MenuForm? _menuForm;
        private protected MenuForm menuForm => _menuForm ??= new MenuForm();
        private PhotoService? _photoService;
        private protected PhotoService photoService => _photoService ??= new PhotoService();
        private PostService? _postService;
        private protected PostService postService => _postService ??= new PostService();
        private MyProfilePage? _myProfile;
        private protected MyProfilePage myProfile => _myProfile ??= new MyProfilePage();
        private protected PostUrlParamsModel postToPost = new PostUrlParamsModel();
        private protected string randomMessage = StringGenerator.RandomString();
        private protected SaveResponseModel photoModel = new SaveResponseModel();
        [SetUp]
        public void SetUp()
        {
            AqualityServices.Browser.GoTo(TestingData.Url);
            AqualityServices.Browser.Maximize();
            postToPost.Message = randomMessage;
            postToPost.OwnerId = TestingData.OwnerId;
            var uploadServerModel = new UploadServerModel(postToPost.OwnerId);
            UploadServerResponseModel resultUploadServer = photoService.GetUploadServer(uploadServerModel).Result;
            string urlForPost = resultUploadServer.response.Upload_url;
            UploadPhotoResponse resultUploadPhoto = photoService.UploadPhotoToServer(urlForPost).Result;
            var SavePhotoModel = new SavePhotoModel(postToPost.OwnerId, postToPost.OwnerId, resultUploadPhoto.Photo, resultUploadPhoto.Server, resultUploadPhoto.Hash);
            photoModel = photoService.PostSaveWallPhoto(SavePhotoModel).Result;
        }

        [TearDown]
        public void AfterEach()
        {
            AqualityServices.Browser.Quit();
        }
    }
}