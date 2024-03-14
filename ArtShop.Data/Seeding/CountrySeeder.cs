using ArtShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtShop.Data.Seeding
{
    internal class CountrySeeder : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(GetCountries());
        }

        private static Country[] GetCountries()
        {
            return
            [
                new Country()
                {
                    Id = 1,
                    Name = "Afghanistan",
                },
                new Country()
                {
                    Id = 2,
                    Name = "South Africa",
                },
                new Country()
                {
                    Id = 3,
                    Name = "Albania",
                },
                new Country()
                {
                    Id = 4,
                    Name = "Germany",
                },
                new Country()
                {
                    Id = 5,
                    Name = "Andorra",
                },
                new Country()
                {
                    Id = 6,
                    Name = "Angola",
                },
                new Country()
                {
                    Id = 7,
                    Name = "Anguilla",
                },
                new Country()
                {
                    Id = 8,
                    Name = "Antarctica",
                },
                new Country()
                {
                    Id = 9,
                    Name = "Antigua and Barbuda",
                },
                new Country()
                {
                    Id = 11,
                    Name = "Saudi Arabia",
                },
                new Country()
                {
                    Id = 12,
                    Name = "Algeria",
                },
                new Country()
                {
                    Id = 13,
                    Name = "Argentina",
                },
                new Country()
                {
                    Id = 14,
                    Name = "Armenia",
                },
                new Country()
                {
                    Id = 15,
                    Name = "Aruba",
                },
                new Country()
                {
                    Id = 16,
                    Name = "Australia",
                },
                new Country()
                {
                    Id = 17,
                    Name = "Austria",
                },
                new Country()
                {
                    Id = 18,
                    Name = "Azerbaijan",
                },
                new Country()
                {
                    Id = 19,
                    Name = "Bahamas, The",
                },
                new Country()
                {
                    Id = 20,
                    Name = "Bahrain",
                },
                new Country()
                {
                    Id = 21,
                    Name = "Bangladesh",
                },
                new Country()
                {
                    Id = 22,
                    Name = "Barbados",
                },
                new Country()
                {
                    Id = 23,
                    Name = "Belgium",
                },
                new Country()
                {
                    Id = 24,
                    Name = "Belize",
                },
                new Country()
                {
                    Id = 25,
                    Name = "Benin",
                },
                new Country()
                {
                    Id = 26,
                    Name = "Bermuda",
                },
                new Country()
                {
                    Id = 27,
                    Name = "Belarus",
                },
                new Country()
                {
                    Id = 28,
                    Name = "Bolivia",
                },
                new Country()
                {
                    Id = 29,
                    Name = "Bosnia and Herzegovina",
                },
                new Country()
                {
                    Id = 30,
                    Name = "Botswana",
                },
                new Country()
                {
                    Id = 31,
                    Name = "Brazil",
                },
                new Country()
                {
                    Id = 32,
                    Name = "Brunei",
                },
                new Country()
                {
                    Id = 33,
                    Name = "Bulgaria",
                },
                new Country()
                {
                    Id = 34,
                    Name = "Burkina Faso",
                },
                new Country()
                {
                    Id = 35,
                    Name = "Burundi",
                },
                new Country()
                {
                    Id = 36,
                    Name = "Bhutan",
                },
                new Country()
                {
                    Id = 37,
                    Name = "Cabo Verde",
                },
                new Country()
                {
                    Id = 38,
                    Name = "Cameroon",
                },
                new Country()
                {
                    Id = 39,
                    Name = "Cambodia",
                },
                new Country()
                {
                    Id = 40,
                    Name = "Canada",
                },
                new Country()
                {
                    Id = 41,
                    Name = "Qatar",
                },
                new Country()
                {
                    Id = 42,
                    Name = "Kazakhstan",
                },
                new Country()
                {
                    Id = 43,
                    Name = "Chad",
                },
                new Country()
                {
                    Id = 44,
                    Name = "Chile",
                },
                new Country()
                {
                    Id = 45,
                    Name = "China",
                },
                new Country()
                {
                    Id = 46,
                    Name = "Cyprus",
                },
                new Country()
                {
                    Id = 47,
                    Name = "Singapore",
                },
                new Country()
                {
                    Id = 48,
                    Name = "Colombia",
                },
                new Country()
                {
                    Id = 49,
                    Name = "Comoros",
                },
                new Country()
                {
                    Id = 50,
                    Name = "Congo",
                },
                new Country()
                {
                    Id = 51,
                    Name = "North Korea",
                },
                new Country()
                {
                    Id = 52,
                    Name = "Korea",
                },
                new Country()
                {
                    Id = 53,
                    Name = "Côte d'Ivoire",
                },
                new Country()
                {
                    Id = 54,
                    Name = "Costa Rica",
                },
                new Country()
                {
                    Id = 55,
                    Name = "Croatia",
                },
                new Country()
                {
                    Id = 56,
                    Name = "Cuba",
                },
                new Country()
                {
                    Id = 57,
                    Name = "Curaçao",
                },
                new Country()
                {
                    Id = 58,
                    Name = "Denmark",
                },
                new Country()
                {
                    Id = 59,
                    Name = "Djibouti",
                },
                new Country()
                {
                    Id = 60,
                    Name = "Dominica",
                },
                new Country()
                {
                    Id = 61,
                    Name = "Egypt",
                },
                new Country()
                {
                    Id = 62,
                    Name = "El Salvador",
                },
                new Country()
                {
                    Id = 63,
                    Name = "United Arab Emirates",
                },
                new Country()
                {
                    Id = 64,
                    Name = "Ecuador",
                },
                new Country()
                {
                    Id = 65,
                    Name = "Eritrea",
                },
                new Country()
                {
                    Id = 66,
                    Name = "Slovakia",
                },
                new Country()
                {
                    Id = 67,
                    Name = "Slovenia",
                },
                new Country()
                {
                    Id = 68,
                    Name = "Spain",
                },
                new Country()
                {
                    Id = 69,
                    Name = "United States",
                },
                new Country()
                {
                    Id = 70,
                    Name = "Estonia",
                },
                new Country()
                {
                    Id = 71,
                    Name = "Ethiopia",
                },
                new Country()
                {
                    Id = 72,
                    Name = "Fiji Islands",
                },
                new Country()
                {
                    Id = 73,
                    Name = "Philippines",
                },
                new Country()
                {
                    Id = 74,
                    Name = "Finland",
                },
                new Country()
                {
                    Id = 75,
                    Name = "France",
                },
                new Country()
                {
                    Id = 76,
                    Name = "Gabon",
                },
                new Country()
                {
                    Id = 77,
                    Name = "Gambia, The",
                },
                new Country()
                {
                    Id = 78,
                    Name = "Ghana",
                },
                new Country()
                {
                    Id = 79,
                    Name = "Georgia",
                },
                new Country()
                {
                    Id = 80,
                    Name = "Gibraltar",
                },
                new Country()
                {
                    Id = 81,
                    Name = "Grenada",
                },
                new Country()
                {
                    Id = 82,
                    Name = "Greece",
                },
                new Country()
                {
                    Id = 83,
                    Name = "Greenland",
                },
                new Country()
                {
                    Id = 84,
                    Name = "Guadeloupe",
                },
                new Country()
                {
                    Id = 85,
                    Name = "Guam",
                },
                new Country()
                {
                    Id = 86,
                    Name = "Guatemala",
                },
                new Country()
                {
                    Id = 87,
                    Name = "Guernsey",
                },
                new Country()
                {
                    Id = 88,
                    Name = "Guyana",
                },
                new Country()
                {
                    Id = 89,
                    Name = "French Guiana",
                },
                new Country()
                {
                    Id = 90,
                    Name = "Guinea",
                },
                new Country()
                {
                    Id = 91,
                    Name = "Equatorial Guinea",
                },
                new Country()
                {
                    Id = 92,
                    Name = "Guinea-Bissau",
                },
                new Country()
                {
                    Id = 93,
                    Name = "Haiti",
                },
                new Country()
                {
                    Id = 94,
                    Name = "Netherlands",
                },
                new Country()
                {
                    Id = 95,
                    Name = "Honduras",
                },
                new Country()
                {
                    Id = 96,
                    Name = "Hong Kong SAR",
                },
                new Country()
                {
                    Id = 97,
                    Name = "Hungary",
                },
                new Country()
                {
                    Id = 98,
                    Name = "Yemen",
                },
                new Country()
                {
                    Id = 99,
                    Name = "Bouvet Island",
                },
                new Country()
                {
                    Id = 100,
                    Name = "Reunion",
                },
                new Country()
                {
                    Id = 101,
                    Name = "Man, Isle of",
                },
                new Country()
                {
                    Id = 102,
                    Name = "Saint Martin (French part)",
                },
                new Country()
                {
                    Id = 103,
                    Name = "Heard Island and McDonald Islands",
                },
                new Country()
                {
                    Id = 104,
                    Name = "Christmas Island",
                },
                new Country()
                {
                    Id = 105,
                    Name = "Norfolk Island",
                },
                new Country()
                {
                    Id = 106,
                    Name = "Åland Islands",
                },
                new Country()
                {
                    Id = 107,
                    Name = "Cayman Islands",
                },
                new Country()
                {
                    Id = 108,
                    Name = "Cocos (Keeling) Islands",
                },
                new Country()
                {
                    Id = 109,
                    Name = "Cook Islands",
                },
                new Country()
                {
                    Id = 110,
                    Name = "Falkland Islands (Islas Malvinas)",
                },
                new Country()
                {
                    Id = 111,
                    Name = "Faroe Islands",
                },
                new Country()
                {
                    Id = 112,
                    Name = "South Georgia and the South Sandwich Islands",
                },
                new Country()
                {
                    Id = 113,
                    Name = "Northern Mariana Islands",
                },
                new Country()
                {
                    Id = 114,
                    Name = "Marshall Islands",
                },
                new Country()
                {
                    Id = 115,
                    Name = "U.S. Minor Outlying Islands",
                },
                new Country()
                {
                    Id = 116,
                    Name = "Pitcairn Islands",
                },
                new Country()
                {
                    Id = 117,
                    Name = "Solomon Islands",
                },
                new Country()
                {
                    Id = 118,
                    Name = "Turks and Caicos Islands",
                },
                new Country()
                {
                    Id = 119,
                    Name = "Virgin Islands, U.S.",
                },
                new Country()
                {
                    Id = 120,
                    Name = "Virgin Islands, British",
                },
                new Country()
                {
                    Id = 121,
                    Name = "India",
                },
                new Country()
                {
                    Id = 122,
                    Name = "Indonesia",
                },
                new Country()
                {
                    Id = 123,
                    Name = "Iran",
                },
                new Country()
                {
                    Id = 124,
                    Name = "Iraq",
                },
                new Country()
                {
                    Id = 125,
                    Name = "Ireland",
                },
                new Country()
                {
                    Id = 126,
                    Name = "Iceland",
                },
                new Country()
                {
                    Id = 127,
                    Name = "Israel",
                },
                new Country()
                {
                    Id = 128,
                    Name = "Italy",
                },
                new Country()
                {
                    Id = 129,
                    Name = "Jamaica",
                },
                new Country()
                {
                    Id = 130,
                    Name = "Japan",
                },
                new Country()
                {
                    Id = 131,
                    Name = "Jersey",
                },
                new Country()
                {
                    Id = 132,
                    Name = "Jordan",
                },
                new Country()
                {
                    Id = 133,
                    Name = "Kiribati",
                },
                new Country()
                {
                    Id = 134,
                    Name = "Kosovo",
                },
                new Country()
                {
                    Id = 135,
                    Name = "Kuwait",
                },
                new Country()
                {
                    Id = 136,
                    Name = "Laos",
                },
                new Country()
                {
                    Id = 137,
                    Name = "Lesotho",
                },
                new Country()
                {
                    Id = 138,
                    Name = "Latvia",
                },
                new Country()
                {
                    Id = 139,
                    Name = "Lebanon",
                },
                new Country()
                {
                    Id = 140,
                    Name = "Liberia",
                },
                new Country()
                {
                    Id = 141,
                    Name = "Libya",
                },
                new Country()
                {
                    Id = 142,
                    Name = "Liechtenstein",
                },
                new Country()
                {
                    Id = 143,
                    Name = "Lithuania",
                },
                new Country()
                {
                    Id = 144,
                    Name = "Luxembourg",
                },
                new Country()
                {
                    Id = 145,
                    Name = "Macao SAR",
                },
                new Country()
                {
                    Id = 146,
                    Name = "Macedonia, Former Yugoslav Republic of",
                },
                new Country()
                {
                    Id = 147,
                    Name = "Madagascar",
                },
                new Country()
                {
                    Id = 148,
                    Name = "Malaysia",
                },
                new Country()
                {
                    Id = 149,
                    Name = "Malawi",
                },
                new Country()
                {
                    Id = 150,
                    Name = "Maldives",
                },
                new Country()
                {
                    Id = 151,
                    Name = "Mali",
                },
                new Country()
                {
                    Id = 152,
                    Name = "Malta",
                },
                new Country()
                {
                    Id = 153,
                    Name = "Morocco",
                },
                new Country()
                {
                    Id = 154,
                    Name = "Martinique",
                },
                new Country()
                {
                    Id = 155,
                    Name = "Mauritius",
                },
                new Country()
                {
                    Id = 156,
                    Name = "Mauritania",
                },
                new Country()
                {
                    Id = 157,
                    Name = "Mayotte",
                },
                new Country()
                {
                    Id = 158,
                    Name = "Mexico",
                },
                new Country()
                {
                    Id = 159,
                    Name = "Micronesia",
                },
                new Country()
                {
                    Id = 160,
                    Name = "Mozambique",
                },
                new Country()
                {
                    Id = 161,
                    Name = "Moldova",
                },
                new Country()
                {
                    Id = 162,
                    Name = "Monaco",
                },
                new Country()
                {
                    Id = 163,
                    Name = "Mongolia",
                },
                new Country()
                {
                    Id = 164,
                    Name = "Montenegro",
                },
                new Country()
                {
                    Id = 165,
                    Name = "Montserrat",
                },
                new Country()
                {
                    Id = 166,
                    Name = "Myanmar",
                },
                new Country()
                {
                    Id = 167,
                    Name = "Namibia",
                },
                new Country()
                {
                    Id = 168,
                    Name = "Nauru",
                },
                new Country()
                {
                    Id = 169,
                    Name = "Nepal",
                },
                new Country()
                {
                    Id = 170,
                    Name = "Nicaragua",
                },
                new Country()
                {
                    Id = 171,
                    Name = "Niger",
                },
                new Country()
                {
                    Id = 172,
                    Name = "Nigeria",
                },
                new Country()
                {
                    Id = 173,
                    Name = "Niue",
                },
                new Country()
                {
                    Id = 174,
                    Name = "Norway",
                },
                new Country()
                {
                    Id = 175,
                    Name = "New Caledonia",
                },
                new Country()
                {
                    Id = 176,
                    Name = "New Zealand",
                },
                new Country()
                {
                    Id = 177,
                    Name = "Oman",
                },
                new Country()
                {
                    Id = 178,
                    Name = "Palau",
                },
                new Country()
                {
                    Id = 179,
                    Name = "Panama",
                },
                new Country()
                {
                    Id = 180,
                    Name = "Papua New Guinea",
                },
                new Country()
                {
                    Id = 181,
                    Name = "Pakistan",
                },
                new Country()
                {
                    Id = 182,
                    Name = "Paraguay",
                },
                new Country()
                {
                    Id = 183,
                    Name = "Peru",
                },
                new Country()
                {
                    Id = 184,
                    Name = "French Polynesia",
                },
                new Country()
                {
                    Id = 185,
                    Name = "Poland",
                },
                new Country()
                {
                    Id = 186,
                    Name = "Puerto Rico",
                },
                new Country()
                {
                    Id = 187,
                    Name = "Portugal",
                },
                new Country()
                {
                    Id = 188,
                    Name = "Kenya",
                },
                new Country()
                {
                    Id = 189,
                    Name = "Kyrgyzstan",
                },
                new Country()
                {
                    Id = 190,
                    Name = "United Kingdom",
                },
                new Country()
                {
                    Id = 191,
                    Name = "Central African Republic",
                },
                new Country()
                {
                    Id = 192,
                    Name = "Congo (DRC)",
                },
                new Country()
                {
                    Id = 193,
                    Name = "Dominican Republic",
                },
                new Country()
                {
                    Id = 194,
                    Name = "Czech Republic",
                },
                new Country()
                {
                    Id = 195,
                    Name = "Romania",
                },
                new Country()
                {
                    Id = 196,
                    Name = "Rwanda",
                },
                new Country()
                {
                    Id = 197,
                    Name = "Russia",
                },
                new Country()
                {
                    Id = 198,
                    Name = "Saara OcIdental",
                },
                new Country()
                {
                    Id = 199,
                    Name = "Bonaire, Sint Eustatius and Saba",
                },
                new Country()
                {
                    Id = 200,
                    Name = "Samoa",
                },
                new Country()
                {
                    Id = 201,
                    Name = "American Samoa",
                },
                new Country()
                {
                    Id = 202,
                    Name = "San Marino",
                },
                new Country()
                {
                    Id = 203,
                    Name = "Saint Helena, Ascension and Tristan da Cunha",
                },
                new Country()
                {
                    Id = 204,
                    Name = "Saint Lucia",
                },
                new Country()
                {
                    Id = 205,
                    Name = "Saint Barthélemy",
                },
                new Country()
                {
                    Id = 206,
                    Name = "Saint Kitts and Nevis",
                },
                new Country()
                {
                    Id = 207,
                    Name = "Sint Maarten (Dutch part)",
                },
                new Country()
                {
                    Id = 208,
                    Name = "Saint Pierre and Miquelon",
                },
                new Country()
                {
                    Id = 209,
                    Name = "São Tomé and Príncipe",
                },
                new Country()
                {
                    Id = 210,
                    Name = "Saint Vincent and the Grenadines",
                },
                new Country()
                {
                    Id = 211,
                    Name = "Senegal",
                },
                new Country()
                {
                    Id = 212,
                    Name = "Sierra Leone",
                },
                new Country()
                {
                    Id = 213,
                    Name = "Serbia",
                },
                new Country()
                {
                    Id = 215,
                    Name = "Seychelles",
                },
                new Country()
                {
                    Id = 216,
                    Name = "Syria",
                },
                new Country()
                {
                    Id = 217,
                    Name = "Somalia",
                },
                new Country()
                {
                    Id = 218,
                    Name = "Sri Lanka",
                },
                new Country()
                {
                    Id = 219,
                    Name = "Swaziland",
                },
                new Country()
                {
                    Id = 220,
                    Name = "Sudan",
                },
                new Country()
                {
                    Id = 221,
                    Name = "South Sudan",
                },
                new Country()
                {
                    Id = 222,
                    Name = "Sweden",
                },
                new Country()
                {
                    Id = 223,
                    Name = "Switzerland",
                },
                new Country()
                {
                    Id = 224,
                    Name = "SuriName",
                },
                new Country()
                {
                    Id = 225,
                    Name = "Jan Mayen",
                },
                new Country()
                {
                    Id = 226,
                    Name = "Thailand",
                },
                new Country()
                {
                    Id = 227,
                    Name = "Taiwan",
                },
                new Country()
                {
                    Id = 228,
                    Name = "Tajikistan",
                },
                new Country()
                {
                    Id = 229,
                    Name = "Tanzania",
                },
                new Country()
                {
                    Id = 230,
                    Name = "French Southern and Antarctic Lands",
                },
                new Country()
                {
                    Id = 231,
                    Name = "British Indian Ocean Territory",
                },
                new Country()
                {
                    Id = 232,
                    Name = "Palestinian Authority",
                },
                new Country()
                {
                    Id = 233,
                    Name = "Democratic Republic of Timor-Leste",
                },
                new Country()
                {
                    Id = 234,
                    Name = "Togo",
                },
                new Country()
                {
                    Id = 235,
                    Name = "Tonga",
                },
                new Country()
                {
                    Id = 236,
                    Name = "Tokelau",
                },
                new Country()
                {
                    Id = 237,
                    Name = "TrinIdad and Tobago",
                },
                new Country()
                {
                    Id = 238,
                    Name = "Tunisia",
                },
                new Country()
                {
                    Id = 239,
                    Name = "Turkmenistan",
                },
                new Country()
                {
                    Id = 240,
                    Name = "Turkey",
                },
                new Country()
                {
                    Id = 241,
                    Name = "Tuvalu",
                },
                new Country()
                {
                    Id = 242,
                    Name = "Ukraine",
                },
                new Country()
                {
                    Id = 243,
                    Name = "Uganda",
                },
                new Country()
                {
                    Id = 244,
                    Name = "Uruguay",
                },
                new Country()
                {
                    Id = 245,
                    Name = "Uzbekistan",
                },
                new Country()
                {
                    Id = 246,
                    Name = "Vanuatu",
                },
                new Country()
                {
                    Id = 247,
                    Name = "Vatican City",
                },
                new Country()
                {
                    Id = 248,
                    Name = "Bolivarian Republic of Venezuela",
                },
                new Country()
                {
                    Id = 249,
                    Name = "Vietnam",
                },
                new Country()
                {
                    Id = 250,
                    Name = "Wallis and Futuna",
                },
                new Country()
                {
                    Id = 251,
                    Name = "Zambia",
                },
                new Country()
                {
                    Id = 252,
                    Name = "Zimbabwe",
                },
            ];
        }
    }
}
