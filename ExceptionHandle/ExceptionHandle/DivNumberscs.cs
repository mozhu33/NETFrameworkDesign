using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
    public class DivNumberscs
    {
        public int arg1 { get; set; }

        public int arg2 { get; set; }

        public int result { get; set; }

        public DivNumberscs()
        {
            result = 0;
        }

        public void division()
        {
            try
            {
                result = arg1 / arg2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("异常：{0}", ex);
            }
            finally
            {
                Console.WriteLine("result:{0}", result);
            }
        }
    }
}
