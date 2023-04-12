namespace MethodsPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ase refebis gareshe wers david smits da sofias.
            //mere changenames (naxe change name) olivias da alvaros, magram main methodi isev davids 
            //da sofias dawers
            //string firstEmployee, secondEmployee;

            //firstEmployee = "David Smith";
            //secondEmployee = "Sophia Watson";

            //Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n");

            //ChangeNames( firstEmployee,  secondEmployee);

            //Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n");


            //ref tavidan gamoitans david da sofia da vso mere shecvlis main metodis
            //da changenamec gamoitans olivia da alvaros da kidev olivia alvaros mainic
            string firstEmployee, secondEmployee;

            firstEmployee = "David Smith";
            secondEmployee = "Sophia Watson";

            Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n");

            ChangeNames(ref firstEmployee, ref secondEmployee);

            Console.WriteLine($"Inside Main Method\n----------\n{firstEmployee} \n{secondEmployee}\n\n
        }

        //static void ChangeNames( string firstEmp,  string secEmp)  // esaa urefo
        //{
        //    firstEmp = "Olivia Aaron";
        //    secEmp = "Alvaro Salazar";
        //    Console.WriteLine($"Outside Main Method\n----------\n{firstEmp} \n{secEmp}\n\n");
        //}

        //refiani

        static void ChangeNames(ref string firstEmp, ref string secEmp)
        {
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method\n----------\n{firstEmp} \n{secEmp}\n\n");
        }

    }
}