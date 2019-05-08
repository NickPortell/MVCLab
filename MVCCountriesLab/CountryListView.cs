using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryListView
    {
        #region Fields
        private List<Country> countries;
        #endregion

        #region Properties
        public List<Country> Countries
        {
            set { countries = value; }
            get { return countries; }
        }
        #endregion

        #region Constructors
        public CountryListView(List<Country> _countries)
        {
            countries = _countries;
        }
        #endregion

        #region Methods
        public void Display()
        {
            Console.WriteLine("\tIndex:\tName:");
            for(int i = 0; i < countries.Count;i++)
            {
                Console.WriteLine($"\t{i}\t{countries[i].Name}");
            }
        }
        #endregion
    }
}
