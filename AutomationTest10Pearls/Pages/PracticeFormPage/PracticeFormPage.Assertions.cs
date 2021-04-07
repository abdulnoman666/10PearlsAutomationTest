using NUnit.Framework;

namespace AutomationTest10Pearls.Pages.PracticeFormPage
{
    internal partial class PracticeFormPage
    {
        internal void AssertSubmitFormResultOnPracticeFormPage(string message)
        {
            StringAssert.AreEqualIgnoringCase("Thanks for submitting the form", message, "Text at submission does not matched");
        }

        internal void AssertFirstNameAsMandatoryFieldOnPracticeFormPage()
        {
            HelperFunctions helperFunction = new HelperFunctions();
            bool flag = helperFunction.isAttribtuePresent(fldFirstName, "required");
            Assert.That(flag.Equals(true), "Required attribute is not present in the First Name field");
        }

        internal void AssertLastNameAsMandatoryFieldOnPracticeFormPage()
        {
            HelperFunctions helperFunction = new HelperFunctions();
            bool flag = helperFunction.isAttribtuePresent(fldLastName, "required");
            Assert.That(flag.Equals(true), "Required attribute is not present in the Last Name field");
        }

        internal void AssertRadioButtonAsMandatoryFieldOnPracticeFormPage()
        {
            HelperFunctions helperFunction = new HelperFunctions();
            bool flag = helperFunction.isAttribtuePresent(rdbtnGender, "required");
            Assert.That(flag.Equals(true), "Required attribute is not present in the Last Name field");
        }
    }
}
