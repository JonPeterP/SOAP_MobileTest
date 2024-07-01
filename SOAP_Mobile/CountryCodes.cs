using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAP_Mobile
{
    internal class CountryCodes
    {
        string[] countryCodes;
        public Dictionary<string, string> countryCodesByName, countryNamesByCode;
        public CountryCodes()
        {
            countryCodes = new string[]{
                        "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AX", "AZ",
                        "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BL", "BM", "BN", "BO", "BQ", "BR", "BS",
                        "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN",
                        "CO", "CR", "CU", "CV", "CW", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ",
                        "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR",
                        "GA", "GB", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT",
                        "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU",
                        "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT",
                        "JE", "JM", "JO", "JP",
                        "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ",
                        "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY",
                        "MA", "MC", "MD", "ME", "MF", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS",
                        "MT", "MU", "MV", "MW", "MX", "MY", "MZ",
                        "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ",
                        "OM",
                        "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PT", "PW", "PY",
                        "QA",
                        "RE", "RO", "RS", "RU", "RW",
                        "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "SS",
                        "ST", "SV", "SX", "SY", "SZ",
                        "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TL", "TM", "TN", "TO", "TR", "TT", "TV", "TW", "TZ",
                        "UA", "UG", "UM", "US", "UY", "UZ",
                        "VA", "VC", "VE", "VG", "VI", "VN", "VU",
                        "WF", "WS",
                        "YE", "YT",
                        "ZA", "ZM", "ZW"
                    };

        }

        public bool CheckAnswer(string answer, string question)
        {

            var client = new CountryInfoService.CountryInfoService();

            Console.WriteLine(((answer.ToUpper()).ToString() + " " +  client.CountryName(question.ToUpper())));
            if (client.CountryISOCode(answer.ToUpper()) != null && (client.CountryName(question.ToUpper()).ToUpper() == answer.ToUpper()))
            {
                return true;
            }
            return false;
        }


        public string[] GetCountryCodes()
        {
            return countryCodes;
        }

        public string GetKeyFromValue(Dictionary<string, string> dictionary, string value)
        {
            foreach (var kvp in dictionary)
            {
                if (kvp.Value == value)
                {
                    return kvp.Key;
                }
            }
            return "no key"; // Return null if the value is not found
        }
    }
}