using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;

namespace userinyerfaceTests.PageObjects.Forms
{
    internal class HelpForm : Form
    {
        private IButton SendToBottomButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'bottom')]"), "Send to bottom button");

        private ILabel HelpFormTitle => ElementFactory.GetLabel(By.XPath("//*[contains(@class,'help-form__title')]"), "Help form title");

        public HelpForm() : base(By.XPath("//*[contains(@class,'help-form__title')]"), "Help form title")
        {
        }

        public void ClickSendToBottomButton()
        {
            SendToBottomButton.Click();     
            HelpFormTitle.State.WaitForNotDisplayed();
        }

    }
}
