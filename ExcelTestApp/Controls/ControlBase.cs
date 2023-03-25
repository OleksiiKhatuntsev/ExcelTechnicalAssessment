using OpenQA.Selenium.Appium.Windows;

namespace ExcelTestApp.Controls
{
    public abstract class ControlBase
    {
        protected WindowsDriver<WindowsElement> Driver { get; }

        internal ControlBase()
        {
            Driver = ExcelWebDriver.GetDriver();
        }
    }
}
