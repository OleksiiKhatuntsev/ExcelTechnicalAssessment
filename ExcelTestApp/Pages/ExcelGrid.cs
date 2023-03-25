using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    public class ExcelGrid : PageObjectBase
    {
        public TextBox ExcelCellByColumnAndRow(string columnLetter, int rowNumber) =>
            new(GetElement(By.XPath($"//*[@AutomationId='{columnLetter}{rowNumber}']")));
    }
}
