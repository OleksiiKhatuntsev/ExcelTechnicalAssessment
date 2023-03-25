using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    internal class DataSnipperToolBarPage : PageObjectBase
    {
        internal Button DataSnipperNavigationButton => new(GetElement(By.Name("DATASNIPPER")));

        internal Button ImportDocumentsButton => new(GetElement(By.Name("Import Documents")));

        internal Button DocumentsButton => new (GetElement(By.XPath("//*[@Name='Documents' and @ClassName='NetUITWBtnMenuItem']")));
    }
}
