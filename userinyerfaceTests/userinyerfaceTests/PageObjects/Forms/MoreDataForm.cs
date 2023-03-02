using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace userinyerfaceTests.PageObjects
{
    internal class MoreDataForm: Form
    {
        public MoreDataForm() : base(By.XPath("//div[contains(@class,'personal-details__td-value')]"), "Data inputs")
        {

        }
    }
}
