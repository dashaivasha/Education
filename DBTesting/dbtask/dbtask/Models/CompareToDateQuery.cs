using dbtask.Constants;
using dbtask.DBServiсe;
using System;
using System.Collections.Generic;

namespace dbtask.Models
{
    internal class CompareToDateQuery
    {
        public string ProjectName;
        public string Name;
        public DateTime StartTime;

        private UnionReportingDb unionReportingDb = new UnionReportingDb();
        public CompareToDateQuery()
        {
        }

        public List<CompareToDateQuery> GetCompareToDateResponse() =>  unionReportingDb.GetCompareToDate();


        public override string ToString()
        {
            return $"{nameof(ProjectName)}: {ProjectName}{Environment.NewLine}" +
                $"{nameof(Name)}: {Name}{Environment.NewLine}" +
                $"{nameof(StartTime)}: {StartTime}{Environment.NewLine}";

        }
    }
}
