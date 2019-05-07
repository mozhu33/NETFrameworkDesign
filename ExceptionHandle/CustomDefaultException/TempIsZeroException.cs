using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDefaultException
{
    public class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message)
            : base(message)
        {

        }
    }

    public class Temperature
    {
        int temperature = 0;

        public void ShowTemperature()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("zero temperature found"));
            }
            else
            {
                Console.WriteLine("temperature:{0}", temperature);
            }
        }
    }
}
