using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace userinyerfaceTests.PageObjects.Forms
{
    public class CookiesForm : Form
    {
        private IButton AcceptCookiesButton => ElementFactory.GetButton(By.XPath("//button[contains(text(),'No')]"), "Accept cookies");

        public CookiesForm() : base(By.XPath("//p[contains(@class,'cookies__message')]"), "Cookies message")
        {
        }

        public void AcceptCookies()
        {
            AcceptCookiesButton.Click();
            AcceptCookiesButton.State.WaitForNotDisplayed();
        }
    }
}
