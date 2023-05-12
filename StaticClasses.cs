namespace StaticClasses
{
    internal class StaticClasses
    {
        static void Main(string[] args)
        {
            // roca staticia classi, Animal animal = new Animal(); sachiro agaraa
            // pirdapir ase madzlevs sasgualebas
            Animal.GetAge();

        }
    }

    static class Animal
    {
        // static class aris animal. amitom memkvidereobas ver miigebs amisgan shvili klasi.
        // magalitad class Dog : Animal ver izavs

        static public string naame;   // static unda iyos esec !


        static public void GetAge() // esec static unda iyos !
        {
            Console.WriteLine(DateTime.Now.Year - DateTime.Now.AddYears(-2).Year);
            //DateTime.Now.AddYears(-2).Year es nishnavs wlevandel wels minus 2 anu 2021 welia es. 2023 - 2021 = 2
        }
    }

}