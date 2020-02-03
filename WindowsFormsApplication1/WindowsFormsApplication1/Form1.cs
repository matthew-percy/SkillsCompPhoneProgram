using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private PhoneNumber Number { get { return (PhoneNumber)PhoneTxtBox.Tag; } }

        public Form1()
        {
            InitializeComponent();

            PhoneList.AddNewCountry("Canada", "1", "230", "235", "240", "250", "416");
            PhoneList.AddNewCountry("USA", "2", "540");
            PhoneList.AddNewCountry("Mexico", "3", "653");
            PhoneList.AddNewCountry("Africa (lol)", "4");
            PhoneList.AddToForm(CountryBox, AreaCodeBox);

            PhoneTxtBox.Tag = new PhoneNumber();
        }

        private void CountryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AreaCodeBox.Items.Clear();
                AreaCodeBox.ResetText();

                foreach (string areaCode in ((Country)CountryBox.SelectedItem).areaCodes)
                    AreaCodeBox.Items.Add(areaCode);

                Number.countryCode = ((Country)CountryBox.SelectedItem).countryCode;
                Number.areaCode = "   ";

                PhoneTxtBox.Text = Number.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PhoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            PhoneNumber currentNumber = Number;
            try
            {
                PhoneTxtBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;//.ExcludePromptAndLiterals;
                PhoneNumber newNumber = new PhoneNumber(PhoneTxtBox.Text);

                foreach (Country country in PhoneList.AllCountries)
                {
                    if (newNumber.ValidatePhoneNumber(country)) //country is valid
                    {
                        currentNumber.UpdateCurrentNumber(newNumber);
                        CountryBox.SelectedItem = country;
                        if (!string.IsNullOrWhiteSpace(currentNumber.areaCode))
                            AreaCodeBox.SelectedItem = currentNumber.areaCode;

                        return;
                    }
                }
                int i = PhoneTxtBox.SelectionStart;
                PhoneTxtBox.Text = currentNumber.ToString(); //reset it back to what it was before being changed
                PhoneTxtBox.SelectionStart = i;
                PhoneTxtBox.Select(Number.ToString().TrimEnd().Length, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                      /*
            foreach (Country country in PhoneList.AllCountries)
            {
                if (PhoneTxtBox.Text.First().ToString() == country.countryCode)
                {
                    CountryBox.SelectedItem = country;
                    currentNumber.countryCode = PhoneTxtBox.Text.First().ToString();
                }
            }

            //get all possible areacodes based on the current phone number

            
            foreach (string areaCode in ((Country)CountryBox.SelectedItem).areaCodes)
            {
                //2,3,4         

                if (PhoneTxtBox.Text[2] != ' ')
                {
                    
                }

                
                if (PhoneTxtBox.Text[2] == areaCode[0])
                {
                    number.areaCode = PhoneTxtBox.Text[2].ToString() + number.areaCode[1].ToString() + number.areaCode[2].ToString();

                }
                if (PhoneTxtBox.Text[3] == areaCode[1])
                {
                    number.areaCode = number.areaCode[0].ToString() + PhoneTxtBox.Text[3].ToString() + number.areaCode[2].ToString();

                }
                if (PhoneTxtBox.Text[4] == areaCode[2])
                {
                    number.areaCode = number.areaCode[0].ToString() + number.areaCode[1].ToString() + PhoneTxtBox.Text[4].ToString();

                }
            }
            */
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(string.Format("Number:{0}\nCountry:{1}", Number, ((Country)CountryBox.SelectedItem).countryName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AreaCodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Number.areaCode = AreaCodeBox.SelectedItem.ToString();
                PhoneTxtBox.Text = Number.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
