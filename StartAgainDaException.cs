namespace ExceptionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            double divResult = 0;

            // sanam sworad ar sheviyvan consoli ar itisheba
            startAgain:

            try
            {
                Console.WriteLine("Enter first number.");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number.");
                secondNumber = int.Parse(Console.ReadLine());


                divResult = firstNumber / secondNumber;
                Console.WriteLine("Result is " + divResult);
            }

            // es zogad erorze axla dawvrilebit ganvixilav erorebs
            //catch 
            //{
            //    Console.WriteLine("Error happened");
            //}


            //ganvixilot erorebi

            // nulze gayofa
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by 0");

                // vabruneb startze  goto startAgain amit
                goto startAgain;
            }
            // aso rom shegyavs magis erori
            catch (FormatException e)
            {
                Console.WriteLine("invalid input");
                goto startAgain;
            }
        }
    }
}