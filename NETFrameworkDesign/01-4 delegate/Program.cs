using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_4_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、最简单的吃零食
            Console.WriteLine("1、最简单的吃零食");
            Eat1.xsEat("零食");
            Console.WriteLine("---------------------------------");

            //2、引入委托
            Console.WriteLine("2、引入委托");
            EatDelegate xs = new EatDelegate(Eat2.xsEat);
            xs("零食");
            Console.WriteLine("---------------------------------");

            //3、委托：多人吃零食
            Console.WriteLine("3、委托：多人吃零食");
            EatDelegate2 xs3 = new EatDelegate2(Eat3.xsEat);
            xs3("零食");
            EatDelegate2 xh = new EatDelegate2(Eat3.xhEat);
            xh("零食");
            EatDelegate2 xm = new EatDelegate2(Eat3.xmEat);
            xm("零食");
            Console.WriteLine("---------------------------------");

            //4、委托链
            Console.WriteLine("4、委托链");
            EatDelegate2 xs4 = new EatDelegate2(Eat3.xsEat);
            EatDelegate2 xh4 = new EatDelegate2(Eat3.xhEat);
            EatDelegate2 xm4 = new EatDelegate2(Eat3.xmEat);

            EatDelegate2 eat;
            eat = xs4 + xh4 + xm4;
            eat("零食");
            Console.WriteLine("---------------------------------");

            //5、委托链2
            Console.WriteLine("5、委托链2");
            Console.WriteLine("小三、小红和小明一起吃零食");
            EatDelegate2 eat2;
            eat2 = xs4 + xh4 + xm4;
            eat2("零食");
            Console.WriteLine("小三有约出去了，就剩下小红和小明吃零食了");
            eat2 -= xs4;
            eat2("零食");
            Console.WriteLine("小红也走了，就剩下小明一个人吃零食了");
            eat2 -= xh4;
            eat2("零食");
            Console.WriteLine("---------------------------------");

            //6、匿名方法
            Console.WriteLine("6、匿名方法");
            EatDelegate2 eat3 = null;
            eat3 += delegate(string food) { Console.WriteLine("小三吃" + food); };
            eat3 += delegate(string food) { Console.WriteLine("小红吃" + food); };
            eat3 += delegate(string food) { Console.WriteLine("小明吃" + food); };
            eat3("零食");
            Console.WriteLine("---------------------------------");

            //7、抽象出人
            Console.WriteLine("7、抽象出人");
            Person xs7 = new Person("小三");
            Person xh7 = new Person("小红");
            Person xm7 = new Person("小明");
            PersonEatDelegate xsEat7 = new PersonEatDelegate(xs7.Eat);
            PersonEatDelegate xhEat7 = new PersonEatDelegate(xh7.Eat);
            PersonEatDelegate xmEat7 = new PersonEatDelegate(xm7.Eat);
            PersonEatDelegate eatChain = null;
            Console.WriteLine("小三、小红和小明一起吃零食");
            eatChain = xsEat7 + xhEat7 + xmEat7;
            eatChain("零食");
            Console.WriteLine("小三有约，出去剩下小红和小明一起吃零食");
            eatChain -= xsEat7;
            eatChain("零食");
            Console.WriteLine("小红也走了，剩下小明自己吃零食");
            eatChain -= xhEat7;
            eatChain("零食");
            Console.WriteLine("---------------------------------");

            

        }
    }
}
