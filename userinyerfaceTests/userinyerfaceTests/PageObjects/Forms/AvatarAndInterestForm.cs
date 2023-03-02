using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using AutoItX3Lib;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using userinyerfaceTests.Constants;
using userinyerfaceTests.PageObjects.Utils;
using userinyerfaceTests.TestData;
using static userinyerfaceTests.Constants.Keys;

namespace userinyerfaceTests.PageObjects.Forms
{
    internal class AvatarAndInterestForm : Form
    {
        private ILink UploadLink => ElementFactory.GetLink(By.XPath("//a[contains(@class,'avatar')]"), "Upload link");
        private IList<ICheckBox> checkBoxesInterests = ElementFactory.FindElements<ICheckBox>(By.XPath("//div[contains(@class,'interests-list__item')]"), "All Intetrests checkboxes");
        private string GetCheckBoxText(ICheckBox checkbox) => checkbox.FindChildElement<ICheckBox>(By.XPath("/div/span[not(contains(@class,'checkbox small'))]")).GetText();
        private ICheckBox GetCheckBoxIcon(ICheckBox checkbox) => checkbox.FindChildElement<ICheckBox>(By.XPath("//span[contains(@class,'checkbox small')]"));
        private AutoItX3 autoIt = new AutoItX3();

        public AvatarAndInterestForm() : base(By.XPath("//a[contains(@class,'avata')]"), "Upload link")
        {
        }

        public void UploadAvatar()
        {
            UploadLink.Click();
            var title = JsonManager.GetTestData(DataKey.FileManagerTitle.GetDescription());
            autoIt.WinWaitActive(title);
            autoIt.Send(PhotoFile.GetFullPath());
            autoIt.Send("{ENTER}");
        }

        public void ChooseInterests()
        {
            var unselectAllCheckboxText = JsonManager.GetTestData(DataKey.UnselectAllCheckboxText.GetDescription());
            var selectAllCheckboxText = JsonManager.GetTestData(DataKey.SelectAllCheckboxText.GetDescription());

            foreach (ICheckBox checkbox in checkBoxesInterests.ToList())
            {
                if (GetCheckBoxText(checkbox) == unselectAllCheckboxText)
                {
                    GetCheckBoxIcon(checkbox).Check();
                    checkBoxesInterests.Remove(checkbox);
                }
                if (GetCheckBoxText(checkbox) == selectAllCheckboxText)
                {
                    checkBoxesInterests.Remove(checkbox);
                }
            }

            CheckRandomInterests();
        }

        private void CheckRandomInterests()
        {
            var rand = new Random();
            var countOfRandomInterests = Convert.ToUInt16(JsonManager.GetTestData(DataKey.CountOfRandomInterests.GetDescription()));

            for (int i = 1; i <= countOfRandomInterests; i++)
            {
                var checkbox = checkBoxesInterests.ElementAt(rand.Next(checkBoxesInterests.Count()));
                GetCheckBoxIcon(checkbox).Check();
            }
        }
    }
}
