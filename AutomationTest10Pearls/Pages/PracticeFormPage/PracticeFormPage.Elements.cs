using OpenQA.Selenium;

namespace AutomationTest10Pearls.Pages.PracticeFormPage
{
    public partial class PracticeFormPage
    {
        IWebElement fldFirstName => HelperFunctions.FindElement("//*[@id='firstName']", 2);
        IWebElement fldLastName => HelperFunctions.FindElement("lastName");
        IWebElement rdbtnMale => HelperFunctions.FindElement("//*[text()='Male']", 2);
        IWebElement fldMobile => HelperFunctions.FindElement("userNumber");
        IWebElement btnSubmit => HelperFunctions.FindElement("submit");
        IWebElement Result => HelperFunctions.FindElement("example-modal-sizes-title-lg");
        IWebElement rdbtnGender => HelperFunctions.FindElement("gender-radio-1");

    }
}
