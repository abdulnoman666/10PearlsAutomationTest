namespace _10PearlsPracticalTest.Pages.PracticeFormPage
{
    public partial class PracticeFormPage
    {
        public void EnterFirstName(string name)
        {
            fldFirstName.SendKeys(name);
        }

        public void EnterLastName(string name)
        {
            fldLastName.SendKeys(name);
        }

        public void ClickMaleRadioButton()
        {
            rdbtnMale.Click();
        }

        public void EnterMobile(string number)
        {
            fldMobile.SendKeys(number);
        }

        public void ClickSubmitButton()
        {
            btnSubmit.Click();
        }


    }
}
