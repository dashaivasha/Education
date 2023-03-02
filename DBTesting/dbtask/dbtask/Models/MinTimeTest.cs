using dbtask.Constants;
using dbtask.DBServiсe;
using System;
using System.Collections.Generic;

namespace dbtask.Models
{
    internal class MinTimeTest
    {
        public string Name;
        public string ProjectName;
        public string MinTime;

        private UnionReportingDb unionReportingDb = new UnionReportingDb();
        public List<MinTimeTest> GetMinTimeTest() => unionReportingDb.GetMinTime();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}{Environment.NewLine}" +
                $"{nameof(ProjectName)}: {ProjectName}{Environment.NewLine}" +
                $"{nameof(MinTime)}: {MinTime}{Environment.NewLine}";
        }
    }
}
