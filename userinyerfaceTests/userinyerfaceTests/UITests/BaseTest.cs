using Aquality.Selenium.Browsers;
using NUnit.Framework;
using userinyerfaceTests.PageObjects;
using userinyerfaceTests.PageObjects.Forms;
using userinyerfaceTests.TestData;
using static userinyerfaceTests.Constants.Keys;

namespace userinyerfaceTests.Base
{
    public abstract class BaseTest
    {
        private MainPage? _mainPage;
        private protected MainPage mainPage => _mainPage ??= new MainPage();
        private CookiesForm? _cookiesForm;
        private protected CookiesForm cookiesForm => _cookiesForm ??= new CookiesForm();

        private RegistrationForm? _registrationForm;
        private protected RegistrationForm registrationForm => _registrationForm ??= new RegistrationForm();

        private protected ButtonsForm buttonsForm => _buttonsForm ??= new ButtonsForm();
        private ButtonsForm? _buttonsForm;

        private protected MoreDataForm dataForm => _dataForm ??= new MoreDataForm();
        private MoreDataForm? _dataForm;

        private protected HelpForm helpForm => _helpForm ??= new HelpForm();
        private HelpForm? _helpForm;

        private protected GamePage gamePage => _gameForm ??= new GamePage();
        private GamePage? _gameForm;

        private AvatarAndInterestForm? _avatarAndInterestForm;
        private protected AvatarAndInterestForm avatarAndInterestForm => _avatarAndInterestForm ??= new AvatarAndInterestForm();

        [SetUp]
        public void SetUp()
        {
            AqualityServices.Browser.GoTo(JsonManager.GetTestData(DataKey.Url.GetDescription()));
            AqualityServices.Browser.Maximize();
        }

        [TearDown]
        public void AfterEach()
        {
            AqualityServices.Browser.Quit();
        }
    }
}