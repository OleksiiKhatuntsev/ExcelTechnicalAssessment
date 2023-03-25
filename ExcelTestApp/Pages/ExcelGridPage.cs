using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    internal class ExcelGridPage : PageObjectBase
    {
        internal TextBox ExcelCellByColumnAndRow(string columnLetter, int rowNumber) =>
            new(GetElement(By.XPath($"//*[@AutomationId='{columnLetter}{rowNumber}']")));
    }
}
