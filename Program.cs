namespace VehicleInheritanceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourWheeledVehicles car = new FourWheeledVehicles();
            car.ChangeColor();
            car.StartVehicle();
            car.RunAtFullSpeed();
        }
    }

    class Vehicle
    {

    }

    class WheeledVehicles : Vehicle
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("Color is changing.\nColor has changed");
        }
    }

    class FourWheeledVehicles : WheeledVehicles
    {
        private string brandName;
        private int capacity;

        public string BrandName { get; set; }
        public int Capacity { get; set; }
       
        public void StartVehicle()
        {
            Console.WriteLine("Car has started");
        }

        public void RunAtFullSpeed()
        {
            Console.WriteLine("Car is running at full speed");
        }


        // shegidzlia dawero ctor da orjer tab
        public FourWheeledVehicles()
        {

        }
    }
}