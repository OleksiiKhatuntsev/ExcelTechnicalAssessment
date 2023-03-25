using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Controls
{
    internal class Label : ControlBase
    {
        private readonly WindowsElement _element;

        internal Label(WindowsElement element)
        {
            _element = element;
        }

        internal void WaitForDisplayed()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(_ => _element.Displayed);
            
        }
    }
}
