using ExcelTestApp;
using FluentAssertions;
using OpenQA.Selenium;

namespace UITests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = Excel.AppiumSetUp();

            var elem = driver.FindElementByName("Blank workbook");
            elem.Click();
            var elem2 = driver.FindElementByName("DATASNIPPER");
            elem2.Click();
            var elem3 = driver.FindElementByName("Import Documents");
            elem3.Click();
            Thread.Sleep(1000);
            var elem4 = driver.FindElement(By.XPath("//*[@ClassName='Edit' and @AutomationId='1148']"));
            elem4.SendKeys("C:\\Users\\Kaelthas\\Downloads\\Oleksii Khatuntsev CV.pdf");
            var elem5 = driver.FindElement(By.XPath("//*[@ClassName='Button' and @AutomationId='1']"));
            elem5.Click();

            Thread.Sleep(5000);
            var elem6 = driver.FindElementByAccessibilityId("SearchBar");
            elem6.SendKeys("QA Automation engineer with");
            elem6.SendKeys(Keys.Enter);

            Thread.Sleep(500);
            var elem8 = driver.FindElementByName("Page 1");
            elem8.Click();

            var elem9 = driver.FindElementByAccessibilityId("A1");
            var result = elem9.Text;

            result.Should().Be("QA Automation engineer with");
        }
    }
}