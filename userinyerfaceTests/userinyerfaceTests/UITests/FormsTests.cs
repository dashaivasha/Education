using Aquality.Selenium.Browsers;
using NUnit.Framework;
using userinyerfaceTests.Base;
using userinyerfaceTests.Constants;
using userinyerfaceTests.TestData;
using static userinyerfaceTests.Constants.Keys;

namespace userinyerfaceTests.UITests
{

    [TestFixture]
    public class FormsTests : BaseTest
    {


        [Test]
        public void AcceptCookiesTest()
        {
            Assert.IsTrue(mainPage.State.WaitForEnabled(), "Welcome page not loaded");
            mainPage.ClickLink();
            cookiesForm.AcceptCookies();
            Assert.IsFalse(cookiesForm.State.WaitForDisplayed(), "Cookies form is still showing");
        }

        [Test]
        public void FormFillingTest()
        {
            Assert.IsTrue(mainPage.State.WaitForEnabled(), "Welcome page not loaded");
            mainPage.ClickLink();
            Assert.IsTrue(registrationForm.State.WaitForEnabled(), "Registration form not loaded");
            registrationForm.EnterPassword();
            registrationForm.EnterEmail();
            registrationForm.EnterDomain();
            registrationForm.ChooseDomain();
            registrationForm.UncheckCheckbox();
            buttonsForm.ClickNextLink();
            Assert.IsTrue(avatarAndInterestForm.State.WaitForEnabled(), "Avatar And interest form not loaded");
            avatarAndInterestForm.UploadAvatar();
            avatarAndInterestForm.ChooseInterests();
            buttonsForm.ClickNextLink();
            Assert.IsTrue(dataForm.State.WaitForEnabled(), "Data form not loaded");
        }

        [Test]
        public void HideHelpFormTest()
        {
            Assert.IsTrue(mainPage.State.WaitForEnabled(), "Welcome page not loaded");
            mainPage.ClickLink();
            helpForm.ClickSendToBottomButton();
            Assert.IsFalse(helpForm.State.WaitForDisplayed(), "Hide form is still showing");
        }


        [Test]
        public void CheckTimerData()
        {
            mainPage.ClickLink();
            gamePage.GetTimerData();
            Assert.AreEqual(JsonManager.GetTestData(DataKey.CorrectTime.GetDescription()), gamePage.GetTimerData(), "Timer data from website is not the same as expected");
        }
    }
}

