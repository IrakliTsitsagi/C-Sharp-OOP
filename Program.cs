namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dogs dog = new Dogs();

            // age miigo axla dogma animalbirthday
            dog.animalBirthDay = DateTime.Now;

            Birds birds = new Birds();
        }
    }

    class Animal 
    {
        public string animalName;
        public DateTime  animalBirthDay;

        public void FeedAnimal() 
        { 
        
        }
    }


    // class Dogs ma class Animalisgan rom aigos animalname, animalBirthDay
    // an Feedanimal metodi, vwert ase : Animal
    class Dogs : Animal
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool easyToTrain;


    }

    class Birds : Animal
    {
        public string birdColor;
        public string birdName;
    }
}