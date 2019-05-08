using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class Country
    {
        #region Fields
        private string name;
        private string continent;
        private List<string> colors;
        #endregion

        #region Properties
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Continent
        {
            set { continent = value; }
            get { return continent; }
        }
        public List<string> Colors
        {
            set { colors = value; }
            get { return colors; }
        }
        #endregion

        #region Constructors
        public Country()
        {
        }
        public Country(string _name,string _continent,List<string> _colors)
        {
            name = _name;
            continent = _continent;
            colors = _colors;
        }
        #endregion

    }
}
