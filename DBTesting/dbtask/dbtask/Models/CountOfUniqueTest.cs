using System;
using System.Collections.Generic;

namespace dbtask.Models
{
    internal class CountOfUniqueTest
    { 
        public string ProjectName;
        public int Count;

        private UnionReportingDb unionReportingDb = new UnionReportingDb();
        public List<CountOfUniqueTest> GetCountOfUniqueTests() => unionReportingDb.GetUniqueTests();

        public override string ToString()
        {
            return $"{nameof(ProjectName)}: {ProjectName}{Environment.NewLine}" +
                $"{nameof(Count)}: {Count}{Environment.NewLine}";
        }
    }
}
