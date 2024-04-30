using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    public class MockReportManager : IReportManager
    {
        public bool ReportSaved { get; private set; }

        public void SaveReport(IEnumerable<string> reportData)
        {
            ReportSaved = true;
        }
    }

}
