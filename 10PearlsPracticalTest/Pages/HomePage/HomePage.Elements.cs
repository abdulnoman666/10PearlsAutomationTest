using OpenQA.Selenium;

namespace _10PearlsPracticalTest.Pages.HomePage
{
    public partial class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement btnForms => driver.FindElement(By.XPath("(//*[name()='svg'])[2]"));
    }
}
