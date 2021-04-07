using OpenQA.Selenium;

namespace AutomationTest10Pearls.Pages.FormsPage
{
    internal partial class FormsPage
    {
        
        IWebElement btnPracticeForm => HelperFunctions.FindElement("//*[text()='Practice Form']", 2);
    }
}
