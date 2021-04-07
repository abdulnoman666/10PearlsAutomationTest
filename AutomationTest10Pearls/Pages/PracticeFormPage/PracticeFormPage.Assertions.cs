using NUnit.Framework;

namespace AutomationTest10Pearls.Pages.PracticeFormPage
{
    public partial class PracticeFormPage
    {
        public void AssertSubmitFormResult(string message)
        {
            StringAssert.AreEqualIgnoringCase("Thanks for submitting the form", message, "Text at submission does not matched");
        }

        public void AssertFirstNameAsMandatoryField()
        {
            HelperFunctions helperFunction = new HelperFunctions();
            bool flag = helperFunction.isAttribtuePresent(fldFirstName, "required");
            Assert.That(flag.Equals(true), "Required attribute is not present in the First Name field");
        }

        public void AssertLastNameAsMandatoryField()
        {
            HelperFunctions helperFunction = new HelperFunctions();
            bool flag = helperFunction.isAttribtuePresent(fldLastName, "required");
            Assert.That(flag.Equals(true), "Required attribute is not present in the Last Name field");
        }

        public void AssertRadioButtonAsMandatoryField()
        {
            HelperFunctions helperFunction = new HelperFunctions();
            bool flag = helperFunction.isAttribtuePresent(rdbtnGender, "required");
            Assert.That(flag.Equals(true), "Required attribute is not present in the Last Name field");
        }
    }
}
