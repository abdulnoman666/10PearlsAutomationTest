using AutomationTest10Pearls.Pages.FormsPage;
using AutomationTest10Pearls.Pages.HomePage;
using AutomationTest10Pearls.Pages.PracticeFormPage;
using NUnit.Framework;

namespace AutomationTest10Pearls
{
    [TestFixture]
    class TestCases
    {
        HelperFunctions helperFunction;
        HomePage homePage;
        FormsPage formPage;
        PracticeFormPage practiceFormPage;
        

        [SetUp]
        public void Init()
        {
            helperFunction = new HelperFunctions();
            homePage = new HomePage();
            formPage = new FormsPage();
            practiceFormPage = new PracticeFormPage();
            helperFunction.OpenBrowser("https://demoqa.com/");
            helperFunction.MaximizeBrowser();
        }

        [Test]
        public void TestCase1()
        {
            homePage.ClickFormsButtonOnHomePage();
            formPage.ClickPracticeFormButtonOnFormsPage();
            practiceFormPage.EnterFirstNameOnPracticeFormPage("Abdul");
            practiceFormPage.EnterLastNameOnPracticeFormPage("Noman");
            practiceFormPage.ClickMaleRadioButtonOnPracticeFormPage();
            practiceFormPage.EnterMobileOnPracticeFormPage("03325155571");
            practiceFormPage.ClickSubmitButtonOnPracticeFormPage();
            practiceFormPage.AssertSubmitFormResultOnPracticeFormPage("Thanks for submitting the form");

        }

        [Test]
        public void TestCase2()
        {
            homePage.ClickFormsButtonOnHomePage();
            formPage.ClickPracticeFormButtonOnFormsPage();
            practiceFormPage.ClickSubmitButtonOnPracticeFormPage();
            practiceFormPage.AssertFirstNameAsMandatoryFieldOnPracticeFormPage();
            practiceFormPage.AssertLastNameAsMandatoryFieldOnPracticeFormPage();
            practiceFormPage.AssertRadioButtonAsMandatoryFieldOnPracticeFormPage();
        }

        [TearDown]
        public void CloseBrowser()
        {
            helperFunction.CloseBrowser();
        }
    }
}
