using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace userinyerfaceTests.PageObjects.Forms
{
    internal class ButtonsForm : Form
    {
        private ILink NextLink => ElementFactory.GetLink(By.XPath("//*[contains(text(),'Next')]"), "Next link");

        public ButtonsForm() : base(By.XPath("//a[contains(text(),'Next')]"), "Next link")
        {
        }

        public void ClickNextLink() => NextLink.Click();
    }
}
