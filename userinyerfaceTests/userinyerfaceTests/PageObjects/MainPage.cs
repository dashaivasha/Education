using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace userinyerfaceTests.PageObjects
{
    internal class MainPage : Form
    {
        private ILabel ClickHereLink => ElementFactory.GetLabel(By.XPath("//a[contains(@href,'game.html')]"), "Click Here Link");

        public MainPage() : base(By.XPath("//a[contains(@href,'game.html')]"), "Click Here Link")
        {
        }

        public void ClickLink() => ClickHereLink.Click();
    }
}
