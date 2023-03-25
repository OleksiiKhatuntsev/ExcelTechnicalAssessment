using ExcelTestApp;
using OpenQA.Selenium.Appium.Windows;

namespace UITests
{
    public class TestBase
    {
        protected WindowsDriver<WindowsElement> Driver { get; }

        public TestBase()
        {
            Driver = ExcelWebDriver.GetDriver();
        }
    }
}
