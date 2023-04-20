namespace MethodsPart4OverloadedMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";
            Console.WriteLine("Hello, Dear Guest, What is Your Name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
            {
                WelcomeGuest();
            }
            else
            {
                WelcomeGuest(guestName);
            }
        }

        static void WelcomeGuest()
        {
            Console.WriteLine("Okay, we hope you anjoy your stay");
        }

        static void WelcomeGuest(string name)
        {
            Console.WriteLine($"Thank you, {name} we hope you anjoy your stay");

        }
    }
}