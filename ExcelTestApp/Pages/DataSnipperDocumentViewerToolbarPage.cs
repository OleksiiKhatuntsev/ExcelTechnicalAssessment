using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    internal class DataSnipperDocumentViewerToolbarPage : PageObjectBase
    {
        internal TextBox SearchTextBox => new(GetElement(By.XPath("//*[@AutomationId='SearchBar']")));

        internal Button SnipWithPageNumber(int pageNumber) => new(GetElement(By.Name($"Page {pageNumber}")));
    }
}
