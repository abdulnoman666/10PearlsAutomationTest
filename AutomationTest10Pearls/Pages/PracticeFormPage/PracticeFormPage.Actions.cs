namespace AutomationTest10Pearls.Pages.PracticeFormPage
{
    public partial class PracticeFormPage
    {
        public void EnterFirstName(string name)
        {
            HelperFunctions.EnterValue(fldFirstName, name);
        }

        public void EnterLastName(string name)
        {
            HelperFunctions.EnterValue(fldLastName, name);
        }

        public void ClickMaleRadioButton()
        {
            HelperFunctions.ClickElement(rdbtnMale);

        }

        public void EnterMobile(string number)
        {
            HelperFunctions.EnterValue(fldMobile,number);
        }

        public void ClickSubmitButton()
        {
            HelperFunctions.ClickElement(btnSubmit);
        }


    }
}
