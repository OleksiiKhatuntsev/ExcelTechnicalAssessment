using ExcelTestApp.Constants;
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

        internal WindowsElement GetElement(By by, int waitForElementSeconds = WaitConstants.DefaultWait)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitForElementSeconds));
            try 
            {
                return wait.Until(_ => Driver.FindElement(by));
            }
            catch (Exception e)
            {
                //Log
                return null;
            }
            
        }
    }
}
