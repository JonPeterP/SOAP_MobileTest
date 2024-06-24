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
        Dictionary<string, string> countryCodesByName;
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
               { "AFGHANISTAN", "AF" }, { "ALBANIA", "AL" }, { "ALGERIA", "DZ" }, { "ANDORRA", "AD" },
            { "ANGOLA", "AO" }, { "ANTIGUA AND BARBUDA", "AG" }, { "ARGENTINA", "AR" }, { "ARMENIA", "AM" },
            { "AUSTRALIA", "AU" }, { "AUSTRIA", "AT" }, { "AZERBAIJAN", "AZ" }, { "BAHAMAS", "BS" },
            { "BAHRAIN", "BH" }, { "BANGLADESH", "BD" }, { "BARBADOS", "BB" }, { "BELARUS", "BY" },
            { "BELGIUM", "BE" }, { "BELIZE", "BZ" }, { "BENIN", "BJ" }, { "BHUTAN", "BT" },
            { "BOLIVIA", "BO" }, { "BOSNIA AND HERZEGOVINA", "BA" }, { "BOTSWANA", "BW" }, { "BRAZIL", "BR" },
            { "BRUNEI DARUSSALAM", "BN" }, { "BULGARIA", "BG" }, { "BURKINA FASO", "BF" }, { "BURUNDI", "BI" },
            { "CABO VERDE", "CV" }, { "CAMBODIA", "KH" }, { "CAMEROON", "CM" }, { "CANADA", "CA" },
            { "CENTRAL AFRICAN REPUBLIC", "CF" }, { "CHAD", "TD" }, { "CHILE", "CL" }, { "CHINA", "CN" },
            { "COLOMBIA", "CO" }, { "COMOROS", "KM" }, { "CONGO", "CG" }, { "CONGO, DEMOCRATIC REPUBLIC OF THE", "CD" },
            { "COSTA RICA", "CR" }, { "CROATIA", "HR" }, { "CUBA", "CU" }, { "CYPRUS", "CY" },
            { "CZECH REPUBLIC", "CZ" }, { "DENMARK", "DK" }, { "DJIBOUTI", "DJ" }, { "DOMINICA", "DM" },
            { "DOMINICAN REPUBLIC", "DO" }, { "ECUADOR", "EC" }, { "EGYPT", "EG" }, { "EL SALVADOR", "SV" },
            { "EQUATORIAL GUINEA", "GQ" }, { "ERITREA", "ER" }, { "ESTONIA", "EE" }, { "ESWATINI", "SZ" },
            { "ETHIOPIA", "ET" }, { "FIJI", "FJ" }, { "FINLAND", "FI" }, { "FRANCE", "FR" },
            { "GABON", "GA" }, { "GAMBIA", "GM" }, { "GEORGIA", "GE" }, { "GERMANY", "DE" },
            { "GHANA", "GH" }, { "GREECE", "GR" }, { "GRENADA", "GD" }, { "GUATEMALA", "GT" },
            { "GUINEA", "GN" }, { "GUINEA-BISSAU", "GW" }, { "GUYANA", "GY" }, { "HAITI", "HT" },
            { "HONDURAS", "HN" }, { "HUNGARY", "HU" }, { "ICELAND", "IS" }, { "INDIA", "IN" },
            { "INDONESIA", "ID" }, { "IRAN", "IR" }, { "IRAQ", "IQ" }, { "IRELAND", "IE" },
            { "ISRAEL", "IL" }, { "ITALY", "IT" }, { "JAMAICA", "JM" }, { "JAPAN", "JP" },
            { "JORDAN", "JO" }, { "KAZAKHSTAN", "KZ" }, { "KENYA", "KE" }, { "KIRIBATI", "KI" },
            { "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "KP" }, { "KOREA, REPUBLIC OF", "KR" }, { "KUWAIT", "KW" }, { "KYRGYZSTAN", "KG" },
            { "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LA" }, { "LATVIA", "LV" }, { "LEBANON", "LB" }, { "LESOTHO", "LS" },
            { "LIBERIA", "LR" }, { "LIBYA", "LY" }, { "LIECHTENSTEIN", "LI" }, { "LITHUANIA", "LT" },
            { "LUXEMBOURG", "LU" }, { "MADAGASCAR", "MG" }, { "MALAWI", "MW" }, { "MALAYSIA", "MY" },
            { "MALDIVES", "MV" }, { "MALI", "ML" }, { "MALTA", "MT" }, { "MARSHALL ISLANDS", "MH" },
            { "MAURITANIA", "MR" }, { "MAURITIUS", "MU" }, { "MEXICO", "MX" }, { "MICRONESIA", "FM" },
            { "MOLDOVA", "MD" }, { "MONACO", "MC" }, { "MONGOLIA", "MN" }, { "MONTENEGRO", "ME" },
            { "MOROCCO", "MA" }, { "MOZAMBIQUE", "MZ" }, { "MYANMAR", "MM" }, { "NAMIBIA", "NA" },
            { "NAURU", "NR" }, { "NEPAL", "NP" }, { "NETHERLANDS", "NL" }, { "NEW ZEALAND", "NZ" },
            { "NICARAGUA", "NI" }, { "NIGER", "NE" }, { "NIGERIA", "NG" }, { "NORTH MACEDONIA", "MK" },
            { "NORWAY", "NO" }, { "OMAN", "OM" }, { "PAKISTAN", "PK" }, { "PALAU", "PW" },
            { "PALESTINE, STATE OF", "PS" }, { "PANAMA", "PA" }, { "PAPUA NEW GUINEA", "PG" }, { "PARAGUAY", "PY" },
            { "PERU", "PE" }, { "PHILIPPINES", "PH" }, { "POLAND", "PL" }, { "PORTUGAL", "PT" },
            { "QATAR", "QA" }, { "ROMANIA", "RO" }, { "RUSSIAN FEDERATION", "RU" }, { "RWANDA", "RW" },
            { "SAINT KITTS AND NEVIS", "KN" }, { "SAINT LUCIA", "LC" }, { "SAINT VINCENT AND THE GRENADINES", "VC" }, { "SAMOA", "WS" },
            { "SAN MARINO", "SM" }, { "SAO TOME AND PRINCIPE", "ST" }, { "SAUDI ARABIA", "SA" }, { "SENEGAL", "SN" },
            { "SERBIA", "RS" }, { "SEYCHELLES", "SC" }, { "SIERRA LEONE", "SL" }, { "SINGAPORE", "SG" },
            { "SLOVAKIA", "SK" }, { "SLOVENIA", "SI" }, { "SOLOMON ISLANDS", "SB" }, { "SOMALIA", "SO" },
            { "SOUTH AFRICA", "ZA" }, { "SOUTH SUDAN", "SS" }, { "SPAIN", "ES" }, { "SRI LANKA", "LK" },
            { "SUDAN", "SD" }, { "SURINAME", "SR" }, { "SWEDEN", "SE" }, { "SWITZERLAND", "CH" },
            { "SYRIAN ARAB REPUBLIC", "SY" }, { "TAJIKISTAN", "TJ" }, { "TANZANIA", "TZ" }, { "THAILAND", "TH" },
            { "TIMOR-LESTE", "TL" }, { "TOGO", "TG" }, { "TONGA", "TO" }, { "TRINIDAD AND TOBAGO", "TT" },
            { "TUNISIA", "TN" }, { "TURKEY", "TR" },  { "TURKMENISTAN", "TM" }, { "TUVALU", "TV" },
            { "UGANDA", "UG" }, { "UKRAINE", "UA" }, { "UNITED ARAB EMIRATES", "AE" }, { "UNITED KINGDOM", "GB" },
            { "UNITED STATES OF AMERICA", "US" }, { "URUGUAY", "UY" }, { "UZBEKISTAN", "UZ" }, { "VANUATU", "VU" },
            { "VENEZUELA", "VE" }, { "VIET NAM", "VN" }, { "YEMEN", "YE" }, { "ZAMBIA", "ZM" },
            { "ZIMBABWE", "ZW" }
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
    }
}