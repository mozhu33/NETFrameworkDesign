using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace _01_3
{
    public class Items:List<Item> ,IEnumerable<Item>
    {
        private Items items;
        public Items Iitemss  //Items成员名称不能与他们的封闭类型相同
        {
            get
            {
                return this.items;
            }
            set
            {
                if (value.Any(item => item.Price <= 0.0))  //验证商品的价格是否正确
                    return;
                this.items = value;
            }
        }

        //不变的值提取出来定义成常量
        public const string VipString = "VIP";
        public const string NormalString = "Normal";

        public Items()
        {
            this.Add(new VipItem() { ItemCode = string.Format(VipString, "001"), ItemName = "光明牛奶" ,Price=36.5});
            this.Add(new VipItem() { ItemCode = string.Format(VipString, "002"), ItemName = "蒙牛牛奶" ,Price=10});
            this.Add(new Item() { ItemCode = string.Format(NormalString, "001"), ItemName = "红富士苹果", Price = 30.5 });
            this.Add(new Item() { ItemCode = string.Format(NormalString, "002"), ItemName = "进口苹果", Price = 60 });
        }

        public IEnumerable<Item> GetVIPItems()
        {
            if (this.Count == 0)
                return null;

            var result = from item in this where item.ItemCode.StartsWith("VIP") select item;
            return result.ToList();
        }

        public IEnumerable<Item> GetNormalItems()
        {
            if (this.Count == 0)
                return null;

            var result = from item in this where item.ItemCode.StartsWith("Normal") select item;
            return result.ToList();
        }
    }
}
