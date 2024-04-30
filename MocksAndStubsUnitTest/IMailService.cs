using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    public interface IMailService
    {
        public void SendMail(string destination, string message);
    }
}
