using ExcelTestApp.Constants;
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
            appiumOptions.AddAdditionalCapability(AppiumCapabilitiesConstants.AppCapability, PathConstants.ExcelPathConstant);
            appiumOptions.AddAdditionalCapability(AppiumCapabilitiesConstants.DeviceNameCapability, AppiumCapabilitiesConstants.DeviceNameValueCapability);
            appiumOptions.AddAdditionalCapability(AppiumCapabilitiesConstants.PlatformNameCapability, AppiumCapabilitiesConstants.PlatformNameValueCapability);

            // Create the WindowsDriver instance
            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(0);
            _driver.Manage().Window.Maximize();

            return _driver;
        }
    }
}
