// aq shevqmni using worldnamespaces rom martivad viyeno yvelaferi iqidan

using WorldNamespace;

namespace CountryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sheqmeni countryOneInstance da countryTwoInstance

            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();

            // sheqmeni CountryLanguages instansio
            CountryLanguages countryLanguages = new CountryLanguages();

            // mianiche ori sxvadasxva ena enumis gamoyenebit
            countryLanguages.FirstLanguage = Languages.Georgian.ToString();
            countryLanguages.SecondLanguage = Languages.English.ToString();

            // assign the instance countryLanguages to countryOneInstance.Languages
            // anu mivaniche es yvelaferi pirvel qveyanas

            countryOneInstance.Language = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.Countryname = "Georgia";
            countryOneInstance.Currency = Currencies.GEL;
            countryOneInstance.Continents = Continents.Europe;

            // gamovidzaxot sayHi pirvelic da meorec argumentiani
            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.Countryname);

            Console.WriteLine($"Planet {countryOneInstance.PlanetName}, country is {countryOneInstance.Countryname} and currency is {countryOneInstance.Currency}");
            Console.WriteLine($"Main language is {countryOneInstance.Language.FirstLanguage}, secondary language is" +
                $" {Languages.English} and the continent is {countryOneInstance.Continents}");  // asec shemidzlia enis chawera

        }
    }
}