using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    public class DataSnipperDocumentViewerToolbarPage : PageObjectBase
    {
        public TextBox SearchTextBox => new(GetElement(By.XPath("//*[@AutomationId='SearchBar']")));

        public Button SnipWithPageNumber(int pageNumber) => new(GetElement(By.Name($"Page {pageNumber}")));
    }
}
