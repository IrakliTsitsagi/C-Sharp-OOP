namespace MethodsPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 8;
            addResult = a + b;
            Console.WriteLine($"{a} + {b} = {addResult}");
            DisplayMessage();

            c = 15;
            d = 10;
            addResult = c + d;
            Console.WriteLine($"{c} + {d} = {addResult}");
            DisplayMessage();
        }

        static void DisplayMessage()
        {
            Console.WriteLine("kanec filma");
            Console.WriteLine("Shen mohkali dzera?");
            Console.WriteLine("date " + DateTime.Now.ToShortTimeString());

            // part 2 shi davamateb axal metods
        }
    }
}
