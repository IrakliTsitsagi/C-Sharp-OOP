namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.DisplayName("Dejan", "Stankovic");
        }
    }

    class Person
    {
        string firstName;
        string lastName;

        public void DisplayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(this.firstName + " " + this.lastName); // amas moaqvs konstriqtoridan
        }

        public void DisplayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public Person()
        {
            firstName = "not determined";
            lastName = string.Empty;
        }
    }
}