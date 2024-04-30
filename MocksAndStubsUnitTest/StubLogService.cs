using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    class StubLogService : ILogService
    {
        public string? lastError;
        public void LogError(string error)
        {
            throw new Exception(error);
        }
    }
}
