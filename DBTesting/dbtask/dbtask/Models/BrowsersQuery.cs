using dbtask.Constants;
using dbtask.DBServiсe;
using System;
using System.Collections.Generic;

namespace dbtask.Models
{
    internal class BrowsersQuery
    {
        public string Browsers;
        private UnionReportingDb unionReportingDb = new UnionReportingDb();

        public List<BrowsersQuery> GetBrowsersTestsCount() => unionReportingDb.GetBrowsers();          


        public override string ToString()
        {
            return $"{nameof(Browsers)}: {Browsers}{Environment.NewLine}";
        }
    }
}
