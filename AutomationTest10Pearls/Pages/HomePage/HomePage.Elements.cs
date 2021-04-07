using OpenQA.Selenium;

namespace AutomationTest10Pearls.Pages.HomePage
{
    public partial class HomePage
    {
        IWebElement btnForms => HelperFunctions.FindElement( "(//*[name()='svg'])[2]", 2);
    }
}
