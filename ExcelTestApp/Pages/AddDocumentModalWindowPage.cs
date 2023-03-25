using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    public class AddDocumentModalWindowPage : PageObjectBase
    {
        public Button OpenButton => new(GetElement(By.XPath("//*[@ClassName='Button' and @AutomationId='1']")));

        public TextBox SearchFileTextBox => new(GetElement(By.XPath("//*[@ClassName='Edit' and @AutomationId='1148']")));
    }
}
