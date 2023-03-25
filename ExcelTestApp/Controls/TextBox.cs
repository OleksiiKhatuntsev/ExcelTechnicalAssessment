using ExcelTestApp.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Controls
{
    public class TextBox : ControlBase
    {
        internal TextBox(WindowsElement element) : base(element)
        { }

        public void SetText(string text, int secondsToWaitElement = WaitConstants.DefaultWait)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(secondsToWaitElement));
            var waitResult = wait.Until(_ => Element.Displayed && Element.Enabled);
            if (waitResult)
            {
                Element.SendKeys(text);
            }
            else
            {
                throw new ElementNotInteractableException("Can't set text on the element");
            }
        }

        public void SetTextAndPressEnter(string text, int secondsToWaitElement = WaitConstants.DefaultWait)
        {
            SetText(text + Keys.Enter, secondsToWaitElement);
        }

        public string GetText()
        {
            return Element.Text;
        }
    }
}
