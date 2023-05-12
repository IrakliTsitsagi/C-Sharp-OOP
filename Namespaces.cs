//ai aq sul zemot

using MyNamespace.GameOfThrones;

namespace Namespaces
{
    internal class Namespaces
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
            // MyNamespace.Animals animalsis sayHis ver dainaxavs imitoro statikuri araa.
            // shesabamisad vshvebit ase

            MyNamespace.Animals animals = new MyNamespace.Animals();
            animals.SayHi();

            // uyure axla qvemot rogorc miweria ase ro ar davwero rogorc qvemotaa shemidzlia suul zemot vqna (axede zemot komentars)
            //MyNamespace.GameOfThrones.HouseStark.SayHi();

            // axla sul zemotas wyalobit vizav ase
            HouseStark.SayHi();

        }
    }
}

namespace MyNamespace
{
    class Animals
    {
        public string animalColor;

        public void SayHi()
        {
            Console.WriteLine("Hi from the custom namespase");
        }
    }

    class Trainers
    {

    }

    // esaa nested namespace. anu MyNamespaceshi vqmni am namespaces

    namespace GameOfThrones
    {
        class HouseStark
        {
            public static void SayHi()
            {
                Console.WriteLine("Hi from the custom nested namespace");
            }
        }
    }
}