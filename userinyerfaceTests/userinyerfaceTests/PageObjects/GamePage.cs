using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using System.Globalization;

namespace userinyerfaceTests.PageObjects
{
    internal class GamePage : Form
    {
        private ILabel Timer => ElementFactory.GetLabel(By.XPath("//div[contains(@class,'timer')]"), "Timer");
        public GamePage() : base(By.XPath("//div[contains(@class,'timer')]"), "timer")
        {
        }

        public string GetTimerData()
        {
            var currentTimerTime = Timer.GetText();
            var time = DateTime.ParseExact(currentTimerTime, "mm:ss:ff", CultureInfo.DefaultThreadCurrentCulture);
            var timeText = time.ToString("mm:ss", CultureInfo.CurrentCulture);

            return timeText;
        }
    }
}
