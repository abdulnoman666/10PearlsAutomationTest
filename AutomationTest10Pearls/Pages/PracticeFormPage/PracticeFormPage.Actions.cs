namespace AutomationTest10Pearls.Pages.PracticeFormPage
{
    internal partial class PracticeFormPage
    {
        internal void EnterFirstNameOnPracticeFormPage(string name)
        {
            HelperFunctions.EnterValue(fldFirstName, name);
        }

        internal void EnterLastNameOnPracticeFormPage(string name)
        {
            HelperFunctions.EnterValue(fldLastName, name);
        }

        internal void ClickMaleRadioButtonOnPracticeFormPage()
        {
            HelperFunctions.ClickElement(rdbtnMale);

        }

        internal void EnterMobileOnPracticeFormPage(string number)
        {
            HelperFunctions.EnterValue(fldMobile,number);
        }

        internal void ClickSubmitButtonOnPracticeFormPage()
        {
            HelperFunctions.ClickElement(btnSubmit);
        }


    }
}
