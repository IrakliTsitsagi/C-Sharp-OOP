namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ase vidzaxebt statikuri metodidan
            SayHi();

            // ase vshvebit ara statikuridan
            // vqmnit klaass person
            //pabliq void uechveli ro publiq iyos
            //shemdeg vidzaxebt ase
            Person person = new Person();
            person.SayHii();
        }


        static void SayHi()
        {
            Console.WriteLine("Hi! from static method");
        }
    }

    class Person
    {
        public void SayHii()
        {
            Console.WriteLine("Hi! from non static method");
        }
    }
}