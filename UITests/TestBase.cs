using System.Diagnostics;
using ExcelTestApp.Facade;

namespace UITests
{
    public class TestBase
    {
        protected DataSnipperFacade DataSnipperFacade { get; set; }
        protected ExcelFacade ExcelFacade { get; set; }

        [OneTimeSetUp]
        public void BeforeAll()
        {
            DataSnipperFacade = new DataSnipperFacade();
            ExcelFacade = new ExcelFacade();
        }

        [SetUp]
        public void BeforeEach()
        { }

        [TearDown]
        public void AfterEach()
        {
            var excelProcesses = Process.GetProcesses().
                                                Where(pr => pr.ProcessName == "EXCEL");

            foreach (var process in excelProcesses)
            {
                process.Kill();
            }
        }
    }
}
