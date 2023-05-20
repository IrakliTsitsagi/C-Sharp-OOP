namespace ExceptionHandling
{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            int x = 0;
            // tu davwer   int x = 3; ubralod rezultats dawers da errors agar dawers radgan ar iyo erori
            int y = 3;
            double div = 0;

            try
            {
                div = y / x;
            }

            // ase mainc damiwers rezultats miuxedavad imisa ro 0 ze vyof ar damaerorebs anu
            //catch
            //{
            //    Console.WriteLine(div);
            //}


            // es damiwers errors tviton ra erroria
            catch (Exception e)
            {
                Console.WriteLine("error is:" + e.Message);
            }

            // es dawers rezultats
            finally
            {
                Console.WriteLine("result is:" + div);
            }
        }
    }
}