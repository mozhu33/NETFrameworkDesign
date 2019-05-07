using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDefaultException
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();

            try
            {
                temperature.ShowTemperature();
            }
            catch (TempIsZeroException ex)
            {
                Console.WriteLine("TempIsZeroException:{0}", ex);
            }

            Console.ReadKey();
        }
    }
}
