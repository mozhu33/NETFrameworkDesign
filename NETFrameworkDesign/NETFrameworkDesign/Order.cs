using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFrameworkDesign
{
    public  class Order
    {
        public int Status { get; set; }
        public Items Items { get; set; }

        public double GetPrices()
        {
            var normalItemList = Items.GetNormalItems();
            double result = 0.0;
            foreach (var item in normalItemList)
            {
                result += item.Price;  //普通商品直接相加
            }

            var VIPItemList = Items.GetVIPItems();
            foreach (var item in VIPItemList)
            {
                result += item.Price + 20; //VIP商品统一下调了20元，所以都需要加上
            }

            return result;
        }
    }
}
