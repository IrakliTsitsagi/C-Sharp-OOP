namespace MethodsPart3Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out ic referensia !
           
          //ar gvaqvs pirveladi mnishveloba, vanichebt chven

            ChangeNames(out string firstEmployee, out string secondEmployee);

            Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n");
        }

       

        static void ChangeNames(out string  firstEmp, out string secEmp)
        {
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method\n----------\n{firstEmp} \n{secEmp}\n\n");
        }

    }
}
