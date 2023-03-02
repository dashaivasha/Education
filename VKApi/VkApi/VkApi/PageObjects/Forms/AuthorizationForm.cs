using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using VkApi.Constants;
using VkApi.TestData;
using static VkApi.Constants.Keys;

namespace VkApi.PageObjects.Forms
{
    internal class AuthorizationForm : Form
    {
        private ITextBox LoginInput => ElementFactory.GetTextBox(By.XPath("//input[contains(@class,'VkIdForm__input')]"), "Login input");
        private IButton SignInButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'signInButton')]"), "SignIn button");

        public AuthorizationForm() : base(By.XPath("//input[contains(@class,'VkIdForm__input')]"), "Login input")
        {
        }

        public void EnterLoginFromTestData() => LoginInput.Type(TestingData.Login);

        public void ClickSignInButton() => SignInButton.Click();
    }
}
