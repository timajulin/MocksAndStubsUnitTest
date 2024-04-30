using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    public interface IReportManager
    {
        void SaveReport(IEnumerable<string> reportData);
    }
}
