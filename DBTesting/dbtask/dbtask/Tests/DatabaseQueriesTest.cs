using dbtask.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace dbtask.Tests
{
    [TestFixture]
    internal class DatabaseQueriesTest : BaseTest
    {
        [Test]
        public void QueriesTest()
        {
            List<MinTimeTest> minTestTimeResponse = testModel.GetMinTimeTest();
            Assert.IsNotEmpty(minTestTimeResponse,"Response is empty");
            minTestTimeResponse.ForEach(response => Console.WriteLine(response.ToString()));
            List<CountOfUniqueTest> countOfUniqueTestResponse = countOfUniqueTestModel.GetCountOfUniqueTests();
            Assert.IsNotEmpty(countOfUniqueTestResponse, "Response is empty");
            countOfUniqueTestResponse.ForEach(response => Logger.Info("Count Of Unique Test Response: " + string.Join(" ", response)));
            List<CompareToDateQuery> compareToDateQueryResponse = compareToDateQueryModel.GetCompareToDateResponse();
            Assert.IsNotEmpty(compareToDateQueryResponse, "Response is empty");
            Console.WriteLine("===Compare to date query:===");
            compareToDateQueryResponse.ForEach(response => Console.WriteLine(response.ToString()));
            List<BrowsersQuery> browsersResponse = browsersModel.GetBrowsersTestsCount();
            Assert.IsNotEmpty(browsersResponse, "Response is empty");
            Console.WriteLine("===Browsers query:===");
            browsersResponse.ForEach(response => Console.WriteLine(response.ToString()));
        }
    }
}
