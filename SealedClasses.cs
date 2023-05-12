namespace SealedClasses
{
    internal class SealedClasses
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            // dog.name ver dainaxavs radgan sealedia. Dogs araa sealed da davinaxav dogBreeds
        }
    }

    sealed class Animal
    {
        public string name;
    }

    class Dogs  // class Dogs : Animal ver vizav radgan sealedia Animali
    {
        public string dogBreed;
    }
}