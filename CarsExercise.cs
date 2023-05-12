using System.Diagnostics;
using System.Transactions;

namespace CarsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mercedes Merc = new Mercedes();
            Merc.DisplayInfo();
            
        }
    }

class Car 
{
    private decimal price;
    public string color;
    protected int maxSpeed;

        // private romaa price mchirdeba shemdegi ram rom shvils (mersedess) access qondes

        public decimal Price 
        { 
            get { return price; } 
            set { price = value; } 
        }

        public virtual void DisplayInfo() 
    {
        price = 10000;
        color = "black";
        maxSpeed = 300;
        Console.WriteLine($"Default Values: Price is {price}, color is {color}, max speed is {maxSpeed}");
    }


}

    class Mercedes : Car
    {
        public override void DisplayInfo()
        {
            // jer es base.displayinfo unda dawero uechveli tu minda orive achvenos mere danarcheni.
            // tu wavshli mxolod overridens dawers, qvemot tu davwer mxolod bases monacemebs orive shemtxvevashi
            base.DisplayInfo();

            // ase vidzaxeb get setis Priceti privats danarcheni chveulebriv isev
            base.Price = 15000;
            base.color = "blue";
            base.maxSpeed = 280;
            
            Console.WriteLine($"Overriden Values: Price is {Price}, color is {color}, max speed is {maxSpeed}");
        }

    }
}
