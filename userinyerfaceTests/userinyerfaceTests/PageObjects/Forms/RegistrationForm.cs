using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using userinyerfaceTests.PageObjects.Utils;
using userinyerfaceTests.TestData;
using static userinyerfaceTests.Constants.Keys;

namespace userinyerfaceTests.PageObjects.Forms
{
    internal class RegistrationForm : Form
    {
        private ITextBox PasswordInput => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Password')]"), "Password input");
        private ITextBox EmailInput => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'email')]"), "Email input");
        private ITextBox DomainInput => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Domain')]"), "Domain input");
        private ILabel DropDownIcon => ElementFactory.GetLabel(By.XPath("//span[contains(@class,'icon icon-chevron-down')]"), "Drop Icon");
        private ILabel DomainText => ElementFactory.GetLabel(By.XPath($"//div[text()='{JsonManager.GetTestData(DataKey.Domain.GetDescription())}']"), "Domain text");
        private ICheckBox IDoNotAcceptCheckBox => ElementFactory.GetCheckBox(By.XPath("//span[contains(@class,'checkbox')]"), "I do not accept the Terms & Conditions checkbox");
        private readonly int _randomTextLength = Convert.ToInt32(JsonManager.GetTestData(DataKey.RandomStringlength.GetDescription()));

        public RegistrationForm() : base(By.XPath("//input[contains(@placeholder,'Password')]"), "Password input")
        {
        }

        public void EnterPassword()
        {
            StringGenerator.password = StringGenerator.Generate(_randomTextLength);
            PasswordInput.ClearAndType(StringGenerator.password);
        }
        public void EnterEmail() => EmailInput.ClearAndType(StringGenerator.Generate(_randomTextLength));
        public void EnterDomain() => DomainInput.ClearAndType(StringGenerator.Generate(_randomTextLength));
        private void ClickDropIcon() => DropDownIcon.Click();

        public void ChooseDomain()
        {
            ClickDropIcon();
            AqualityServices.Browser.ExecuteScript(JavaScript.ScrollToElement, DomainText.GetElement());
            DomainText.Click();
        }

        public void UncheckCheckbox() => IDoNotAcceptCheckBox.Check();
    }
}
