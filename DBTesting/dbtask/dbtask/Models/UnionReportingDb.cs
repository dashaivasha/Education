using dbtask.DBServiсe;
using dbtask.TestData;
using System;
using System.Collections.Generic;
using System.Text;

namespace dbtask.Models
{
    internal class UnionReportingDb
    {
        private DbConnect db = new DbConnect();
        public List<BrowsersQuery> GetBrowsers() => db.RunQuery<BrowsersQuery>(Queries.SelectChromeAndFirefox);
        public List<MinTimeTest> GetMinTime() => db.RunQuery<MinTimeTest>(Queries.SelectMinTimeTests);
        public List<CompareToDateQuery> GetCompareToDate() => db.RunQuery<CompareToDateQuery>(Queries.SelectCompareToDate);

        public List<CountOfUniqueTest> GetUniqueTests() => db.RunQuery<CountOfUniqueTest>(Queries.SelectUniqueTests);
    }
}
