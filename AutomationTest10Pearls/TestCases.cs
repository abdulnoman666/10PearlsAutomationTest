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
            homePage.ClickFormsButton();
            formPage.ClickPracticeFormButton();
            practiceFormPage.EnterFirstName("Abdul");
            practiceFormPage.EnterLastName("Noman");
            practiceFormPage.ClickMaleRadioButton();
            practiceFormPage.EnterMobile("03325155571");
            practiceFormPage.ClickSubmitButton();
            practiceFormPage.AssertSubmitFormResult("Thanks for submitting the form");

        }

        [Test]
        public void TestCase2()
        {
            homePage.ClickFormsButton();
            formPage.ClickPracticeFormButton();
            practiceFormPage.ClickSubmitButton();
            practiceFormPage.AssertFirstNameAsMandatoryField();
            practiceFormPage.AssertLastNameAsMandatoryField();
            practiceFormPage.AssertRadioButtonAsMandatoryField();
        }

        [TearDown]
        public void CloseBrowser()
        {
            helperFunction.CloseBrowser();
        }
    }
}
