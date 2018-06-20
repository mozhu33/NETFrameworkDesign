using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public class VipItem:Item
    {
        private double price;
        public override double Price  //todo:override用法
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
    }
}
