using OpenQA.Selenium;

namespace _10PearlsPracticalTest.Pages.FormsPage
{
    public partial class FormsPage
    {
        IWebDriver driver;
        public FormsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement btnPracticeForm => driver.FindElement(By.XPath("//*[text()='Practice Form']"));
    }
}
