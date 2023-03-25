using ExcelTestApp.Pages;
using FluentAssertions;

namespace UITests
{
    public class E2ETests : TestBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            AddDocumentModalWindowPage addDocumentModalWindowPage = new AddDocumentModalWindowPage();
            HomePage homePage = new HomePage();
            DataSnipperToolBarPage dataSnipperToolBarPage = new DataSnipperToolBarPage();
            DataSnipperDocumentViewerToolbarPage toolbarPage = new DataSnipperDocumentViewerToolbarPage();
            ExcelGrid excelGrid = new ExcelGrid();

            homePage.BlankWorkbookButton.Click();
            
            dataSnipperToolBarPage.DataSnipperNavigationButton.Click();
            dataSnipperToolBarPage.DImportDocumentsButton.Click();
            
            addDocumentModalWindowPage.SearchFileTextBox.SetText(@"C:\Users\Kaelthas\Downloads\Oleksii Khatuntsev CV.pdf");
            addDocumentModalWindowPage.OpenButton.Click();

            toolbarPage.SearchTextBox.SetTextAndPressEnter("QA Automation engineer with");
            toolbarPage.SnipWithPageNumber(1).Click();
            
            var result = excelGrid.ExcelCellByColumnAndRow("A", 1).GetText();
            result.Should().Be("QA Automation engineer with");
        }
    }
}