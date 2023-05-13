using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// sheqmeni namespace saxelad WorldNamespace
namespace WorldNamespace
{

    // sheqmeni abstraqtuli klasi worldi
    abstract class World
    {

        // miveci privat parametrebi 
        private string planetName;
        private Continents continents;

        // shemdeg gavuwere propertyebi
        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continents Continents
        {
            get { return continents; }
            set { continents = value; }
        }
    }

    //shevqmeni worldis shvili klasi country
    class Country : World
    {

        // miveci country name, dedaqalaqi, valuta da enebi. 1 ena da 2 ena amitom structi shevqmeni qvemot
        private string countryName;
        private string capital;
        private Currencies currency;
        private CountryLanguages countryLanguages;

        // gavuwerot propertyebi imitoro privatebia isini

        public string Countryname
        {
            get { return countryName; }
            set { countryName = value; }
        }


        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }


        public CountryLanguages Language
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }


        // shevqmeni konstruqtori qveynis saxelze da dedaqalaqze defaulti ro achvenos tu ar aqvs mnishvneloba minichebuli
        public Country()
        {
            Countryname = "Unknown";
            Capital = "Unknown";
        }


        // shevqmeni ori overloaded metodi erti uargumento
        public void SayHi()
        {
            Console.WriteLine("Welcome There");
        }


        // meore erti string argumentit
        public void SayHi(string country)
        {
            Console.WriteLine($"Welcome There pal from {country}");
        }
    }


    // miveci 2 ena
    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }

    // kontinentebis sia
    enum Continents
    {
        Asia,
        Africa,
        Antarctica,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica
    }


    // valutis sia
    enum Currencies
    {
        GEL,
        USD,
        EUR,
        RUB,
        GBP
    }


    // enebis sia
    enum Languages
    {
        Georgian,
        AmericanEnglish,
        French,
        Russian,
        English
    }

}
