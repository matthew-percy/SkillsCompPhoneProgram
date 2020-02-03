using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1
{
    public class PhoneNumber
    {
        public string countryCode = " ";
        public string areaCode = "   ";
        public string middleDigits = "   ";
        public string finalDigits = "    ";


        public override string ToString()
        {
            //return base.ToString();
            //return "";
            return countryCode + areaCode + middleDigits + finalDigits;
            //return string.Format("{0}({1})-{2}-{3}", countryCode, areaCode, middleDigits, finalDigits);
        }

        public void UpdateCurrentNumber(PhoneNumber newNumber)
        {
            countryCode = newNumber.countryCode;
            areaCode = newNumber.areaCode;
            middleDigits = newNumber.middleDigits;
            finalDigits = newNumber.finalDigits;
        }

        public PhoneNumber() { }
        public PhoneNumber(string text)
        {
            string formattedText = text.Replace("(", "");
            formattedText = formattedText.Replace(")", "");
            formattedText = formattedText.Replace("-", "");
            formattedText = formattedText.Replace("_", " ");

            countryCode = formattedText.First().ToString();
            areaCode = formattedText.Substring(1, 3);
            middleDigits = formattedText.Substring(4, 3);
            finalDigits = formattedText.Substring(7, 4);

            
            //int length = text.Length;

            //finalDigits = string.Empty;
            //for (int i = length - 4; i < length; i++)
            //{
            //    finalDigits += text[i];
            //}
            //finalDigits = //text.Substring(finalDigits.LastIndexOf(finalDigits.Last()));

        }

        public bool ValidatePhoneNumber(Country country) //returns true if phonenumber matches the country
        {
            bool validCountryCode = false;
            bool validAreaCode = false;

            //bool AreaCodeFirstDigitValid = false;
            //bool AreaCodeSecondDigitValid = false;
            //bool AreaCodeThirdDigitValid = false;

            if (string.IsNullOrWhiteSpace(countryCode) || countryCode == country.countryCode)
                validCountryCode = true;

            if (string.IsNullOrWhiteSpace(areaCode))
                validAreaCode = true;


            //List<string> firstValueValid = country.areaCodes.Where(x => x[0] == areaCode[0]).ToList();
            //List<string> secondValueValid = country.areaCodes.Where(x => x[1] == areaCode[1]).ToList();
            //List<string> thirdValueValid = country.areaCodes.Where(x => x[2] == areaCode[2]).ToList();

            //List<string> allPossibilities = firstValueValid.Union(secondValueValid).Union(thirdValueValid).ToList();
            if (country.areaCodes.Count >= 1)
            {
                List<string> firstValueValid = new List<string>();
                List<string> secondValueValid = new List<string>();
                List<string> thirdValueValid = new List<string>();

                if (areaCode[0] != ' ')
                {
                    foreach (string areaCode in country.areaCodes)
                    {
                        if (this.areaCode[0] == areaCode[0])
                            firstValueValid.Add(areaCode);
                    }
                }
                else { firstValueValid = country.areaCodes.ToList(); }

                if (areaCode[1] != ' ')
                {
                    foreach (string areaCode in firstValueValid)
                    {
                        if (this.areaCode[1] == areaCode[1])
                            secondValueValid.Add(areaCode);
                    }
                }
                else { secondValueValid = firstValueValid.ToList(); }

                if (areaCode[2] != ' ')
                {
                    foreach (string areaCode in secondValueValid)
                    {
                        if (this.areaCode[2] == areaCode[2])
                            thirdValueValid.Add(areaCode);
                    }
                }
                else { thirdValueValid = secondValueValid.ToList(); }

                if (thirdValueValid.Count >= 1) validAreaCode = true;
            }
            else { validAreaCode = true; }
            /*
            if (areaCode[0] == ' ')
            {
                firstValueValid = country.areaCodes.ToList();
            }
            else
            {
                firstValueValid = country.areaCodes.Where(x => x[0] == areaCode[0]).ToList();
            }
            foreach(*/

            //foreach (string code in allPossibilities)
            //{

            //}

            //if (areaCode[0] != ' ')//string.IsNullOrWhiteSpace(areaCode[0].ToString())
            //{

            //}

            //if (string.IsNullOrWhiteSpace(areaCode[0].ToString()))
            //{

            //}

            //if (areaCode[0] == ' ') //if first digit is valid
            //{

            //}



            if (countryCode == country.countryCode)
            {
                foreach (string areaCode in country.areaCodes)
                {
                    if (this.areaCode == areaCode)
                    {
                        validAreaCode = true;//return true;
                        break;
                    } 
                }
            }

            return validCountryCode & validAreaCode;//false;//false;
        }
    }
}
