using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    public class Country
    {
        public string countryName;
        public string countryCode;
        public List<string> areaCodes;

        public Country(string countryName, string countryCode, params string[] areaCodes)
        {
            this.countryName = countryName;
            this.countryCode = countryCode;
            this.areaCodes = areaCodes.ToList();

        }

        public override string ToString()
        {
            return countryName;
        }



    }
}
