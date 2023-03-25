using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace ExcelTestApp
{
    public static class ExcelWebDriver
    {
        private static WindowsDriver<WindowsElement> _driver;

        public static WindowsDriver<WindowsElement> GetDriver()
        {
            if (_driver != null)
            {
                return _driver;
            }

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            appiumOptions.AddAdditionalCapability("platformName", "Windows");

            // Create the WindowsDriver instance
            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(0);
            
            return _driver;
        }
    }
}
