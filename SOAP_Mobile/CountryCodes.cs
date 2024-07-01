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


            countryCodesByName = new Dictionary<string, string>()
            {
                  { "ANDORRA", "AD" }, { "UNITED ARAB EMIRATES", "AE" }, { "AFGHANISTAN", "AF" },
    { "ANTIGUA AND BARBUDA", "AG" }, { "ANGUILLA", "AI" }, { "ALBANIA", "AL" },
    { "ARMENIA", "AM" }, { "ANGOLA", "AO" }, { "ANTARCTICA", "AQ" }, { "ARGENTINA", "AR" },
    { "AMERICAN SAMOA", "AS" }, { "AUSTRIA", "AT" }, { "AUSTRALIA", "AU" }, { "ARUBA", "AW" },
    { "ÅLAND ISLANDS", "AX" }, { "AZERBAIJAN", "AZ" }, { "BOSNIA AND HERZEGOVINA", "BA" },
    { "BARBADOS", "BB" }, { "BANGLADESH", "BD" }, { "BELGIUM", "BE" }, { "BURKINA FASO", "BF" },
    { "BULGARIA", "BG" }, { "BAHRAIN", "BH" }, { "BURUNDI", "BI" }, { "BENIN", "BJ" },
    { "SAINT BARTHÉLEMY", "BL" }, { "BERMUDA", "BM" }, { "BRUNEI DARUSSALAM", "BN" },
    { "BOLIVIA", "BO" }, { "BONAIRE, SINT EUSTATIUS, AND SABA", "BQ" }, { "BRAZIL", "BR" },
    { "BAHAMAS", "BS" }, { "BHUTAN", "BT" }, { "BOUVET ISLAND", "BV" }, { "BOTSWANA", "BW" },
    { "BELARUS", "BY" }, { "BELIZE", "BZ" }, { "CANADA", "CA" }, { "COCOS (KEELING) ISLANDS", "CC" },
    { "CONGO, DEMOCRATIC REPUBLIC OF THE", "CD" }, { "CENTRAL AFRICAN REPUBLIC", "CF" }, { "CONGO", "CG" },
    { "SWITZERLAND", "CH" }, { "IVORY COAST", "CI" }, { "COOK ISLANDS", "CK" }, { "CHILE", "CL" },
    { "CAMEROON", "CM" }, { "CHINA", "CN" }, { "COLOMBIA", "CO" }, { "COSTA RICA", "CR" },
    { "CUBA", "CU" }, { "CABO VERDE", "CV" }, { "CURACAO", "CW" }, { "CHRISTMAS ISLAND", "CX" },
    { "CYPRUS", "CY" }, { "CZECH REPUBLIC", "CZ" }, { "DENMARK", "DK" }, { "DJIBOUTI", "DJ" },
    { "DOMINICA", "DM" }, { "DOMINICAN REPUBLIC", "DO" }, { "ECUADOR", "EC" }, { "ESTONIA", "EE" },
    { "EGYPT", "EG" }, { "WESTERN SAHARA", "EH" }, { "ERITREA", "ER" }, { "SPAIN", "ES" },
    { "ETHIOPIA", "ET" }, { "FINLAND", "FI" }, { "FIJI", "FJ" }, { "FALKLAND ISLANDS", "FK" },
    { "MICRONESIA", "FM" }, { "FAROE ISLANDS", "FO" }, { "FRANCE", "FR" }, { "GABON", "GA" },
    { "UNITED KINGDOM", "GB" }, { "GRENADA", "GD" }, { "GEORGIA", "GE" }, { "FRENCH GUIANA", "GF" },
    { "GUERNSEY", "GG" }, { "GHANA", "GH" }, { "GIBRALTAR", "GI" }, { "GREENLAND", "GL" },
    { "GAMBIA", "GM" }, { "GUINEA", "GN" }, { "GUADELOUPE", "GP" }, { "EQUATORIAL GUINEA", "GQ" },
    { "GREECE", "GR" }, { "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "GS" }, { "GUATEMALA", "GT" },
    { "GUAM", "GU" }, { "GUINEA-BISSAU", "GW" }, { "GUYANA", "GY" }, { "HONG KONG", "HK" },
    { "HEARD ISLAND AND MCDONALD ISLANDS", "HM" }, { "HONDURAS", "HN" }, { "CROATIA", "HR" },
    { "HAITI", "HT" }, { "HUNGARY", "HU" }, { "INDONESIA", "ID" }, { "IRELAND", "IE" },
    { "ISRAEL", "IL" }, { "ISLE OF MAN", "IM" }, { "INDIA", "IN" }, { "BRITISH INDIAN OCEAN TERRITORY", "IO" },
    { "IRAQ", "IQ" }, { "IRAN", "IR" }, { "ICELAND", "IS" }, { "ITALY", "IT" }, { "JERSEY", "JE" },
    { "JAMAICA", "JM" }, { "JORDAN", "JO" }, { "JAPAN", "JP" }, { "KENYA", "KE" }, { "KYRGYZSTAN", "KG" },
    { "CAMBODIA", "KH" }, { "KIRIBATI", "KI" }, { "COMOROS", "KM" }, { "SAINT KITTS AND NEVIS", "KN" },
    { "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "KP" }, { "KOREA, REPUBLIC OF", "KR" }, { "KUWAIT", "KW" },
    { "CAYMAN ISLANDS", "KY" }, { "KAZAKHSTAN", "KZ" }, { "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LA" },
    { "LEBANON", "LB" }, { "SAINT LUCIA", "LC" }, { "LIECHTENSTEIN", "LI" }, { "SRI LANKA", "LK" },
    { "LIBERIA", "LR" }, { "LESOTHO", "LS" }, { "LITHUANIA", "LT" }, { "LUXEMBOURG", "LU" },
    { "LATVIA", "LV" }, { "LIBYA", "LY" }, { "MOROCCO", "MA" }, { "MONACO", "MC" }, { "MOLDOVA", "MD" },
    { "MONTENEGRO", "ME" }, { "SAINT MARTIN", "MF" }, { "MADAGASCAR", "MG" }, { "MARSHALL ISLANDS", "MH" },
    { "MAURITANIA", "MR" }, { "MAURITIUS", "MU" }, { "MEXICO", "MX" }, { "MALAYSIA", "MY" },
    { "MALDIVES", "MV" }, { "MALAWI", "MW" }, { "MALI", "ML" }, { "MALTA", "MT" },
    { "MONGOLIA", "MN" }, { "MOZAMBIQUE", "MZ" }, { "MYANMAR", "MM" }, { "NAMIBIA", "NA" },
    { "NEW CALEDONIA", "NC" }, { "NIGER", "NE" }, { "NORFOLK ISLAND", "NF" }, { "NIGERIA", "NG" },
    { "NICARAGUA", "NI" }, { "NETHERLANDS", "NL" }, { "NORWAY", "NO" }, { "NEPAL", "NP" },
    { "NAURU", "NR" }, { "NEW ZEALAND", "NZ" }, { "OMAN", "OM" }, { "PANAMA", "PA" },
    { "PERU", "PE" }, { "FRENCH POLYNESIA", "PF" }, { "PAPUA NEW GUINEA", "PG" }, { "PHILIPPINES", "PH" },
    { "PAKISTAN", "PK" }, { "POLAND", "PL" }, { "SAINT PIERRE AND MIQUELON", "PM" }, { "PITCAIRN", "PN" },
    { "PUERTO RICO", "PR" }, { "PORTUGAL", "PT" }, { "PALAU", "PW" }, { "PARAGUAY", "PY" },
    { "QATAR", "QA" }, { "REUNION", "RE" }, { "ROMANIA", "RO" }, { "SERBIA", "RS" }, { "RUSSIAN FEDERATION", "RU" },
    { "RWANDA", "RW" }, { "SAUDI ARABIA", "SA" }, { "SOLOMON ISLANDS", "SB" }, { "SEYCHELLES", "SC" },
    { "SUDAN", "SD" }, { "SWEDEN", "SE" }, { "SINGAPORE", "SG" }, { "SAINT HELENA", "SH" },
    { "SLOVENIA", "SI" }, { "SVALBARD AND JAN MAYEN", "SJ" }, { "SLOVAKIA", "SK" }, { "SIERRA LEONE", "SL" },
    { "SAN MARINO", "SM" }, { "SENEGAL", "SN" }, { "SOMALIA", "SO" }, { "SURINAME", "SR" },
    { "SOUTH SUDAN", "SS" }, { "SAO TOME AND PRINCIPE", "ST" }, { "EL SALVADOR", "SV" },
    { "SINT MAARTEN", "SX" }, { "SYRIAN ARAB REPUBLIC", "SY" }, { "TAJIKISTAN", "TJ" },
    { "TOKELAU", "TK" }, { "TIMOR-LESTE", "TL" }, { "TURKMENISTAN", "TM" }, { "TUNISIA", "TN" },
    { "TURKEY", "TR" }, { "TRINIDAD AND TOBAGO", "TT" }, { "TUVALU", "TV" }, { "TAIWAN", "TW" },
    { "TANZANIA", "TZ" }, { "UGANDA", "UG" }, { "UNITED STATES OF AMERICA", "US" },
    { "URUGUAY", "UY" }, { "UZBEKISTAN", "UZ" }, { "VATICAN CITY STATE", "VA" },
    { "SAINT VINCENT AND THE GRENADINES", "VC" }, { "VENEZUELA", "VE" }, { "VIRGIN ISLANDS, BRITISH", "VG" },
    { "VIRGIN ISLANDS, U.S.", "VI" }, { "VIET NAM", "VN" }, { "VANUATU", "VU" },
    { "WALLIS AND FUTUNA", "WF" }, { "SAMOA", "WS" }, { "YEMEN", "YE" }, { "MAYOTTE", "YT" },
    { "SOUTH AFRICA", "ZA" }, { "ZAMBIA", "ZM" }, { "ZIMBABWE", "ZW" }
            };
        }

        public bool CheckAnswer(string answer, string question)
        {
            if (countryCodesByName.ContainsKey(answer.ToUpper()) && question.ToUpper() == countryCodesByName[answer.ToUpper()])
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