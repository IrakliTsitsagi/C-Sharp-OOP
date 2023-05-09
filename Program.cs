namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wesi nomeri 1 ver dawer abstractis dros amas
            // Shapes shape = new Shapes();


            //axla shvilis meshveobit davukavshirdebi

            Lines line = new Lines();
            line.SayHi(); line.Draw();

        }
    }

    abstract class Shapes
    {

        //ase vqmnit abstraqtul metods arc brchyalebi unda arc rame vso sheqmnilia egre

        abstract public void Draw();


        public void SayHi()
        {
            Console.WriteLine("Hi from the abstract class");
        }
    }

    // rom mqondes wvdoma SayHi() metodze, shevqmnit shvil klass da iqidan vukavshirdebit

    class Lines : Shapes
    {

        // Lines miwitlebs aq overridit unda mivwvdet
        public override void Draw()
        {
            Console.WriteLine("I'm a line;");
        }
    }
}

