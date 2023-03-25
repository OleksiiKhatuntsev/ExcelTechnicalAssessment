using ExcelTestApp.Constants;
using ExcelTestApp.Helpers;
using FluentAssertions;

namespace UITests
{
    public class E2ETests : TestBase
    {
        [Test]
        public void SelectTextFromPdfTest()
        {
            string searchStringAsActualResult = "QA Automation engineer with";

            ExcelFacade.CreateFileAndOpenDataSnipperTab();

            DataSnipperFacade.ClickAddDocumentAndSelectFile(DocumentLoadHelper.GetFullPathOfTestDocument(TestDataPathConstants.CvTestDocument));
            DataSnipperFacade.SearchAndSnip(searchStringAsActualResult);
            
            var result = ExcelFacade.GetDataFromCell();
            result.Should().Be(searchStringAsActualResult);
        }
    }
}