using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    class BoxService
    {
        ILogService logService;
        IMailService mailService;
        IDataAccess dataAccess;
        IReportManager reportManager;
        public BoxService(ILogService service, IMailService mailService, IDataAccess dataAccess, IReportManager reportManager)
        {
            this.logService = service;
            this.mailService = mailService;
            this.dataAccess = dataAccess;
            this.reportManager = reportManager;
        }
        public void Analyze(string fileName)
        {
            try
            {
                if (fileName.Length < 8) { logService.LogError("Filename is too short: " + fileName); }
                if (Path.GetExtension(fileName) != ".txt") { logService.LogError("FileExtension error: " + fileName); }
            }
            catch (Exception ex)
            {
                mailService.SendMail("some@mail.mail", ex.Message);
            }
        }
        public void ProcessFilesFromDatabase()
        {
            IEnumerable<string> fileNames = dataAccess.GetFileNamesFromDatabase();

            if (fileNames != null)
            reportManager.SaveReport(fileNames);
        }

    }
}
