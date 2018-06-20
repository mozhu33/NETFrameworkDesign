using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFrameworkDesign
{
    public class Items:List<Item> ,IEnumerable<Item>
    {
        public Items()
        {
            this.Add(new Item { ItemCode = "VIP_001", ItemName = "光明牛奶", Price = 36.5 });
            this.Add(new Item { ItemCode = "Normal_001", ItemName = "红富士苹果", Price = 30.5 });
            this.Add(new Item { ItemCode = "VIP_002", ItemName = "蒙牛牛奶", Price = 10 });
            this.Add(new Item { ItemCode = "Normal_002", ItemName = "进口苹果", Price = 60 });
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
