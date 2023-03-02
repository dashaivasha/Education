using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace VkApi.PageObjects.Forms
{
    internal class MenuForm : Form
    {
        private ILink MyProfileLink => ElementFactory.GetLink(By.XPath("//li[@id='l_pr']/a"), "MyProfile link");

        public MenuForm() : base(By.XPath("//li[@id='l_pr']/a]"), "MyProfile link")
        {
        }

        public void ClickMyProfileLink()
        {
            MyProfileLink.State.WaitForDisplayed();
            MyProfileLink.WaitAndClick();
        }
    }
}
