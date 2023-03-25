using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Controls
{
    public class Button : ControlBase
    {
        private readonly WindowsElement _element;

        internal Button(WindowsElement element)
        {
            _element = element;
        }

        public void Click()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var waitResult = wait.Until(_ => _element.Displayed && _element.Enabled);
            if (waitResult)
            {
                _element.Click();
            }
            else
            {
                throw new ElementClickInterceptedException("Can't click on the element");
            }
        }
    }
}
