using ExcelTestApp.Controls;
using OpenQA.Selenium;

namespace ExcelTestApp.Pages
{
    internal class DataSnipperGettingStartedWindowPage : PageObjectBase
    {
        internal Label GettingStartedLabel => new(GetElement(By.Name("Getting Started")));
    }
}
