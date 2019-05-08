using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryController
    {
        #region Fields
        private List<Country> countryDb;
        #endregion

        #region Properties
        public List<Country> CountryDb
        {
            set { countryDb = value; }
            get { return countryDb; }
        }
        #endregion

        #region Constructors
        //public CountryController()
        //{

        //}
        #endregion

        #region Methods
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            string response = "yes";
            

            CountryListView listView = new CountryListView(countryDb);
            Console.WriteLine("Hello, welcome to the country app.");

            while (response == "yes")
            {
                Console.WriteLine("Please select a country from the following list: ");
                listView.Display();

                string selection = isValid(countryDb.Count);

                for (int i = 0; i < countryDb.Count; i++)
                {
                    if (selection == i.ToString())
                    {
                        CountryAction(countryDb[i]);
                    }
                    
                }

                Console.WriteLine("\nWould you like to learn about another Country? (yes/no)");
                response = Console.ReadLine().ToLower();
                Console.Clear();
            }
            Console.WriteLine("\nThank you!");
        }
        #endregion

        #region Validation Method
        public string isValid( int max)
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int num))
            {
                Console.Clear();
                Console.WriteLine($"{input} is not a valid option. Please choose a number from 0-{countryDb.Count - 1}\n");
                Console.WriteLine("==================================================================");
                return isValid(max);
            }
            else if (num < 0 || num > max)
            {
                Console.Clear();
                Console.WriteLine($"{input} is not a valid option. Please choose a number from 0-{countryDb.Count - 1}\n");
                Console.WriteLine("==================================================================");
                return isValid(max);
            }
            return input;
            
        }
        #endregion
    }
}
