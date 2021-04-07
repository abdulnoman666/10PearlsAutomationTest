
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace AutomationTest10Pearls
{
    [TestFixture]
    public class HelperFunctions
    {
        private static readonly string driverPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        private static IWebDriver driver = null;

        public static IWebDriver GetDriver()
        {
            driver = new ChromeDriver(driverPath + "\\ChromeDriver");
            return driver;
        }

        public void OpenBrowser(string url)
        {
            var driver = GetDriver();
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public void MaximizeBrowser()
        {
            driver.Manage().Window.Maximize();
        }

        public Boolean isAttribtuePresent(IWebElement element, String attribute)
        {
            Boolean result = false;
            try
            {
                String value = element.GetAttribute(attribute);
                if (value != "True")
                {
                    result = true;
                }
            }
            catch (Exception e) { }

            return result;
        }

        internal static IWebElement FindElement(string selector, int findByType = 1)
        {
            IWebElement element = null;
            try
            {
                if (findByType == 1)
                    element = driver.FindElement(By.Id(selector));
                else
                    element = driver.FindElement(By.XPath(selector));
            }
            catch (Exception x)
            {
                Assert.Fail("Element not found with selector: "+ selector);
            }
            
            return element;
        }

        internal static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        internal static void EnterValue(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
    }
}
