using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    public class HomePage : PageObjectBase
    {
        public Button BlankWorkbookButton => new(GetElement(By.Name("Blank workbook")));
    }
}
