using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    public class DataSnipperToolBarPage : PageObjectBase
    {
        public Button DataSnipperNavigationButton => new(GetElement(By.Name("DATASNIPPER")));

        public Button DImportDocumentsButton => new(GetElement(By.Name("Import Documents")));
    }
}
