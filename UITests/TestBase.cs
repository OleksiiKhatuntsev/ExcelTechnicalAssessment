using System.Runtime.CompilerServices;
using ExcelTestApp;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace UITests
{
    public class TestBase
    {
        private IWebDriver _driver;
        
        [SetUp]
        public void BeforeEach()
        {
            _driver = ExcelWebDriver.GetDriver();
        }

        [TearDown]
        public void AfterEach()
        {
            _driver.Quit();
        }
    }
}
