namespace MethodSimpleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetName();
        }


        //saxeli ro sheiyvano imis metodi
        static void GetName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            SayHi(name);
        }


        //sheyvanili saxeli rom dabechdos imis metodi
        static void SayHi(string name)
        {
            name = ToUpperCaseFirst(name);
            Console.WriteLine($"Welcome back {name}");
        }


        //pirveli aso ro didi iyos danarchenebi patara imis metodi
        static string ToUpperCaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();

        }
    }
}
