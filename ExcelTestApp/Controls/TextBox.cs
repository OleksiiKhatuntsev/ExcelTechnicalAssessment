using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace ExcelTestApp.Controls
{
    public class TextBox : ControlBase
    {
        private readonly WindowsElement _element;

        internal TextBox(WindowsElement element)
        {
            _element = element;
        }

        public void SetText(string text)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var waitResult = wait.Until(_ => _element.Displayed && _element.Enabled);
            if (waitResult)
            {
                _element.SendKeys(text);
            }
            else
            {
                throw new ElementNotInteractableException("Can't set text on the element");
            }
        }

        public void SetTextAndPressEnter(string text)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var waitResult = wait.Until(_ => _element.Displayed && _element.Enabled);
            if (waitResult)
            {
                _element.SendKeys(text + Keys.Enter);
            }
            else
            {
                throw new ElementNotInteractableException("Can't set text on the element");
            }
        }

        public string GetText()
        {
            return _element.Text;
        }
    }
}
