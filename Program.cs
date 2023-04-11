namespace MethodsPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;


            // es voidiani metodi

            //a = 5;
            //b = 8;
            //PerformAddOperation(a, b);


            //c = 15;
            //d = 10;
            //PerformAddOperation(c, d);


            //es uvoido metodi
            a = 5;
            b = 8;
            addResult = PerformAddOperation(a, b);
            Console.WriteLine($"{a} + {b} = {addResult}");
            DisplayMessage();

            c = 15;
            d = 10;
            addResult = PerformAddOperation(c, d);
            Console.WriteLine($"{c} + {d} = {addResult}");
            DisplayMessage();
        }

        static void DisplayMessage()
        {

            Console.WriteLine("kanec filma");
            Console.WriteLine("Shen mohkali dzera?");
            Console.WriteLine("date " + DateTime.Now.ToShortTimeString());
        }


        //voidiani
        //static void PerformAddOperation(int x, int y)
        //{
        //    // es aris voidi anu ar abrunebs mnishvnelobas
        //    int addResult = 0;
        //    addResult = x + y;
        //    Console.WriteLine($"{x} + {y} = {addResult}");
        //    DisplayMessage();  // metods vidzaxeb metodshi da agar miwevs mainshi wera
        //}



        //uvoido
        static int PerformAddOperation(int x, int y)
        {
            // es ar aris voidi anu abrunebs mnishvnelobas
            int addResult = 0;
            addResult = x + y;
            return addResult;

        }
    }
}