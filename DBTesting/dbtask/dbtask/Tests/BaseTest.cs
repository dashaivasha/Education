using dbtask.Models;
using Aquality.Selenium.Core.Logging;

namespace dbtask.Tests
{
    public abstract class BaseTest
    {
        private MinTimeTest? _minTime; 
        private protected MinTimeTest testModel => _minTime ??= new MinTimeTest();
        private CountOfUniqueTest? _countOfUniqueTestModel;
        private protected CountOfUniqueTest countOfUniqueTestModel => _countOfUniqueTestModel ??= new CountOfUniqueTest();
        private CompareToDateQuery? _compareToDateQueryModel;
        private protected CompareToDateQuery compareToDateQueryModel => _compareToDateQueryModel ??= new CompareToDateQuery();
        private BrowsersQuery? _browsersModel;
        private protected BrowsersQuery browsersModel => _browsersModel ??= new BrowsersQuery();
        private protected static Logger Logger => Logger.Instance;
    }
}