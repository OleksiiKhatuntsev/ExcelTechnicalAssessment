using ExcelTestApp.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Controls
{
    public class Button : ControlBase
    {
        internal Button(WindowsElement element) : base(element)
        { }

        public void Click(int secondsToWaitElement = WaitConstants.DefaultWait)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(secondsToWaitElement));
            var waitResult = wait.Until(_ => Element.Displayed && Element.Enabled);
            if (waitResult)
            {
                Element.Click();
            }
            else
            {
                throw new ElementClickInterceptedException("Can't click on the element");
            }
        }
    }
}
