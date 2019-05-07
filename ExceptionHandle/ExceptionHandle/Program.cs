using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            DivNumberscs divNumber1 = new DivNumberscs()
            {
                arg1 = 10,
                arg2 = 3
            };
            divNumber1.division();

            DivNumberscs divNumber2 = new DivNumberscs()
            {
                arg1 = 2,
                arg2 = 0
            };
            divNumber2.division();

            Console.ReadKey();

        }
    }
}
