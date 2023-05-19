namespace Interfaces
{
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
            dog.SayHi();
            dog.Run();
        }
    }

    public interface IAnimalCommands
    {
        void Run();
    }

    public interface IDogCommands : IAnimalCommands
    {
        void Stay();
        void Sit();
        void Attack();

        string DogName
        {
            set; get;
        }
    }

    interface ITrainers
    {

    }

    class Animals
    {
        string AnimalName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the Animals class");
        }
    }

    // jer iwereba klasi mere interface memkvidreobisas, calcalke sheidzleba ratqmUNDA MARTO INTERFACES DAMEMKVIDREBA
    // ar shemidzlia ori klasidan memkvidreobis migeba magram ori interfeisidan shemidzlia - IDogCommands da ITrainers
    class Dogs : Animals, IDogCommands, ITrainers
    {
        public void Stay()
        {
            Console.WriteLine("Dog is staying");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is sitting");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is attaacking");
        }

        public void Run()
        {
            Console.WriteLine("Animal is running");
        }

        public string DogName { get; set; }
    }
}