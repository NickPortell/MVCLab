using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();

            #region Countries in 'countries'
            Country c1 = new Country("United States", "North America",new List<string>{"Red","White","Blue"});
            countries.Add(c1);

            Country c2 = new Country("Algeria","Africa", new List<string> { "Green", "White", "Red" });
            countries.Add(c2);

            Country c3 = new Country("Angola","Africa", new List<string> { "Red", "White", "Blue" });
            countries.Add(c3);

            Country c4 = new Country("Benin","Africa", new List<string> { "Green", "Yellow", "Red" });
            countries.Add(c4);

            Country c5 = new Country("Botswana","Africa", new List<string> { "Light Blue", "Black", "White" });
            countries.Add(c5);

            Country c6 = new Country("Kenya","Africa", new List<string> { "Black","Red","Green", "White"});
            countries.Add(c6);

            Country c7 = new Country("Libya","Africa", new List<string> { "Red", "Black", "Green", "White"});
            countries.Add(c7);

            Country c8 = new Country("Madagascar","Africa", new List<string> { "Red","Green","White"});
            countries.Add(c8);

            Country c9 = new Country("Antiqua and Barbuda","North America", new List<string> { "Red", "White", "Blue","Black","Yellow"});
            countries.Add(c9);

            Country c10 = new Country("Montserrat","North America", new List<string> { "Black", "Green","Dark Blue","Red","White"});
            countries.Add(c10);

            Country c11 = new Country("France", "Europe", new List<string> { "Blue", "White", "Red" });
            countries.Add(c11);

            Country c12 = new Country("Italy", "Europe", new List<string> {"Green", "White", "Red"});
            countries.Add(c12);
            #endregion 

            CountryController controller = new CountryController();
            controller.CountryDb = countries;

            CountryListView listView = new CountryListView(countries);

            controller.WelcomeAction();

        }
    }
}
