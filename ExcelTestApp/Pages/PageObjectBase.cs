using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Pages
{
    internal class PageObjectBase
    {
        private WindowsDriver<WindowsElement> Driver { get; }

        internal PageObjectBase()
        {
            Driver = ExcelWebDriver.GetDriver();
        }

        internal WindowsElement GetElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(_ => Driver.FindElement(by));
            return element;
        }
    }
}
