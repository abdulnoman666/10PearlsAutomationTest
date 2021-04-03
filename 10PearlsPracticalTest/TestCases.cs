using _10PearlsPracticalTest.Pages.FormsPage;
using _10PearlsPracticalTest.Pages.HomePage;
using _10PearlsPracticalTest.Pages.PracticeFormPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _10PearlsPracticalTest
{
    class TestCases
    {
        HelperFunctions helperFunction;
        HomePage homePage;
        FormsPage formPage;
        PracticeFormPage practiceFormPage;

        IWebDriver driver;

        [SetUp]
        public void OpenBrower()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            formPage = new FormsPage(driver);
            practiceFormPage = new PracticeFormPage(driver);
            helperFunction = new HelperFunctions(driver);
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
