using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_4_delegate
{
    delegate void EatDelegate2(string food);

    public class Eat3
    {
        public static void xsEat(string food)
        {
            Console.WriteLine("小三吃" + food);
        }

        public static void xhEat(string food)
        {
            Console.WriteLine("小红吃" + food);
        }

        public static void xmEat(string food)
        {
            Console.WriteLine("小明吃" + food);
        }
    }
}
