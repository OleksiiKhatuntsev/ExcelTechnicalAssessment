using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    internal class HomePage : PageObjectBase
    {
        internal Button BlankWorkbookButton => new(GetElement(By.Name("Blank workbook")));
    }
}
