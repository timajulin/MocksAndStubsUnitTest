namespace MocksAndStubsUnitTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var logService = new StubLogService();
            var mailService = new MockMailService();
            var dataAccess = new StubDataAccess();
            var reportManager = new MockReportManager();

            var box = new BoxService(logService, mailService, dataAccess, reportManager);

            string fileName = "SomeFile.log";
            box.Analyze(fileName);

            Assert.That(mailService.message, Is.EqualTo("FileExtension error: " + fileName));

            box.ProcessFilesFromDatabase();
            Assert.IsTrue(reportManager.ReportSaved);
        }
    }
}