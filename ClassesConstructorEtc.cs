using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person perOne= new Person();
            perOne.FirstName = "Irakla";
            perOne.LastName = "Cicaga";
            perOne.BirthDate = DateTime.Now;
            perOne.Country = "Saqartvelo";

            Person perTwo = new Person();
            perTwo.FirstName = "Dejan";
            perTwo.LastName = "Stankovichi";
            perTwo.BirthDate = DateTime.Now;
            perTwo.Country = "Serbeti";


            Person perThree = new Person();

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName);
            Console.WriteLine(perThree.FirstName);

        }

        class Person
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string country;


            // asec sheidzleba
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            // asec sheidzleba vwert prop da 2 jer tabi, mere gadavaketebt
            public DateTime BirthDate { get; set; }

            public string Country { get; set; }


            //konstruqtori aris esaa Person()
            public Person() 
            {
                firstName = "unknown";
            }
        }
    }
}
