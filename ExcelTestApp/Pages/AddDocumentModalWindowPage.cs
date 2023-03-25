using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    internal class AddDocumentModalWindowPage : PageObjectBase
    {
        internal Button OpenButton => new(GetElement(By.XPath("//*[@ClassName='Button' and @AutomationId='1']")));

        internal TextBox SearchFileTextBox => new(GetElement(By.XPath("//*[@ClassName='Edit' and @AutomationId='1148']")));
    }
}
