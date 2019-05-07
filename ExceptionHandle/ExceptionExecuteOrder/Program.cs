using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExecuteOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、
            //DivNumbers divNumber1 = new DivNumbers()
            //{
            //    arg1 = null,
            //    arg2 = 1
            //};

            //2、
            DivNumbers divNumber1 = new DivNumbers()
            {
                arg1 = 1,
                arg2 = 0
            };
            try
            {
                divNumber1.division();
            }
             //3、
            catch (IsZeroException ex)
            {
                Console.WriteLine("IsZeroException：{0}", ex);
            }
            catch (ArgsIsNullException ex)
            {
                Console.WriteLine("ArgsIsNullException:{0}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:{0}", ex);
            }
            finally
            {
                Console.WriteLine("执行结束！！");
            }

            Console.ReadKey();
        }
    }
}
