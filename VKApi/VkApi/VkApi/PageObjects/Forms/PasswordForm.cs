using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using VkApi.TestData;
using static VkApi.Constants.Keys;

namespace VkApi.PageObjects.Forms
{
    internal class PasswordForm : Form
    {
        private ITextBox PasswordInput => ElementFactory.GetTextBox(By.XPath("//input[@name='password']"), "Password input");
        private IButton СontinueButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'vkuiButton')]"), "Сontinue button");

        public PasswordForm() : base(By.XPath("//input[@name='password']"), "Password input")
        {
        }

        public void EnterPassword() => PasswordInput.Type(TestingData.Password);
        public void ClickContinueButton() => СontinueButton.ClickAndWait();
    }
}
