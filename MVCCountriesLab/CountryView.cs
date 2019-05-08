using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryView
    {
        #region Fields
        private Country displayCountry;
        #endregion

        #region Properties
        public Country DisplayCountry
        {
            set { displayCountry = value; }
            get { return displayCountry; }
        }
        #endregion

        #region Constructors
        public CountryView(Country _displayCountry)
        {
            displayCountry = _displayCountry;
        }
        #endregion

        #region Methods
        public void Display()
        {
            Console.Write($"\tName: {displayCountry.Name}\n\tContinent: {displayCountry.Continent}\n\tColors: ");

            foreach (string color in displayCountry.Colors)
            {
                Console.Write($"{color} ");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
