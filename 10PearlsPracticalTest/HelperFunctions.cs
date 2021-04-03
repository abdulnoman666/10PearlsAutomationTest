
using OpenQA.Selenium;
using System;

namespace _10PearlsPracticalTest
{
    public class HelperFunctions
    {
        IWebDriver driver;
        public HelperFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void OpenBrowser(string url)
        {
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
    }
}
