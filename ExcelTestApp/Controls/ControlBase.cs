using ExcelTestApp.Constants;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Controls
{
    public abstract class ControlBase
    {
        protected WindowsDriver<WindowsElement> Driver { get; }

        protected readonly WindowsElement? Element;

        internal ControlBase(WindowsElement element)
        {
            Element = element;
            Driver = ExcelWebDriver.GetDriver();
        }

        internal bool WaitForDisplayed(int secondsToWaitElement = WaitConstants.DefaultWait)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(secondsToWaitElement));
            
            if (Element == null)
            {
                return false;
            }

            return wait.Until(_ => Element.Displayed);
        }
    }
}
