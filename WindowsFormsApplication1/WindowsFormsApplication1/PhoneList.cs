using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class PhoneList
    {
        public static List<Country> AllCountries = new List<Country>();

        public static void AddToForm(ComboBox countryBox, ComboBox areaBox)
        {
            foreach (Country country in AllCountries)
            {
                countryBox.Items.Add(country);
            }

        }
        public static void AddNewCountry(string countryName, string countryCode, params string[] areaCodes)
        {
            AllCountries.Add(new Country(countryName, countryCode, areaCodes));
        }

    }
}
