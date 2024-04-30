using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    class MockMailService : IMailService
    {
        public string? message;
        public string? destination;
        public void SendMail(string destination, string message)
        {
            this.message = message;
            this.destination = destination;
        }
    }
}
