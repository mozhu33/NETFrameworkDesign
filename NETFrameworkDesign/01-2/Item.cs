using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_2
{
    public class Item
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public virtual double Price { get; set; }  //todo:Virtual 用法
    }
}
