using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_4_delegate
{
    delegate void PersonEatDelegate(string food);

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public void Eat(string food)
        {
            Console.WriteLine(this.Name + "吃" + food);
        }
    }
}
