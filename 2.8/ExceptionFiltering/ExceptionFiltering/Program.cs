using System;

namespace ExceptionFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("ex 1");
                throw new Exception("ex 2");
            }
            catch (Exception ex) if (ex.Message == "ex 1")
            {
                Console.WriteLine("This is ex 1");
            }
            catch (Exception ex) if (ex.Message == "ex 2")
            {
                Console.WriteLine("This is ex 2");
            }

            Console.ReadKey();
        }
    }
}
