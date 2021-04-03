using OpenQA.Selenium;

namespace _10PearlsPracticalTest.Pages.PracticeFormPage
{
    public partial class PracticeFormPage
    {
        IWebDriver driver;
        public PracticeFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement fldFirstName => driver.FindElement(By.XPath("//*[@id='firstName'] "));
        IWebElement fldLastName => driver.FindElement(By.Id("lastName"));
        IWebElement rdbtnMale => driver.FindElement(By.XPath("//*[text()='Male']"));
        IWebElement fldMobile => driver.FindElement(By.Id("userNumber"));
        IWebElement btnSubmit => driver.FindElement(By.Id("submit"));
        IWebElement Result => driver.FindElement(By.Id("example-modal-sizes-title-lg"));
        IWebElement rdbtnGender => driver.FindElement(By.Id("gender-radio-1"));

    }
}
