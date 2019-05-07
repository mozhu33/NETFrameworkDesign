using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();

            try
            {
                example.CatchInner();
            }
            catch (AppException ex)
            {
                Console.WriteLine("In catch block of main method");
                Console.WriteLine("catch:{0}", ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception:{0}", ex.InnerException);
                }
            }

            Console.ReadKey();
        }
    }
}
