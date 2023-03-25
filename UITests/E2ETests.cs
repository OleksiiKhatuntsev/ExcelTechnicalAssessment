using ExcelTestApp.Facade;
using FluentAssertions;

namespace UITests
{
    public class E2ETests : TestBase
    {
        [Test]
        public void SelectTextFromPdfTest()
        {
            DataSnipperFacade dataSnipperFacade = new DataSnipperFacade();
            ExcelFacade excelFacade = new ExcelFacade();

            excelFacade.CreateFileAndOpenDataSnipperTab();

            dataSnipperFacade.ClickAddDocumentAndSelectFile(@"C:\Users\Kaelthas\Downloads\Oleksii Khatuntsev CV.pdf");
            dataSnipperFacade.SearchAndSnip("QA Automation engineer with");
            
            var result = excelFacade.GetDataFromCell();
            result.Should().Be("QA Automation engineer with");
        }
    }
}