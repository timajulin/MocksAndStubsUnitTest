using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    public class StubDataAccess : IDataAccess
    {
        public IEnumerable<string> GetFileNamesFromDatabase()
        {
            return new List<string> { "file1.txt", "file2.txt", "file3.txt" };
        }
    }
}
