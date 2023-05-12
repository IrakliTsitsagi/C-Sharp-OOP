namespace NestedClasses
{
    internal class NestedClasses
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            // ase vshvebit nested klassis shemtxvevashi
            Animals.Dogs dog = new Animals.Dogs();
            Animals.Cats cat = new Animals.Cats();

            // eseni rom dainaxos
            cat.catName = "Mia";
            dog.dogName = "Iriska";

            Console.WriteLine(cat.catName + " da " + dog.dogName);


        }
    }

    class Animals
    {
        public string animalName;
        public string animalCountry;

        // nested klasebia qvemot. animalsshia dogsic catsic
        public class Dogs
        {
            public string dogName;
            public string dogBreed;
        }

        public class Cats
        {
            public string catName;

        }
    }
}