using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_4_delegate
{
    delegate void EatDelegate(string food);

    public class Eat2
    {
        public static void xsEat(string food)
        {
            Console.WriteLine("小三吃" + food);
        }
    }
}
