using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public class OperationNormalPrices:IOperationNormalPrices
    {
        public double GetPrices(Order order)
        {
            var normalItemList = order.Items.GetNormalItems();
            double result = 0.0;
            foreach (var item in normalItemList)
            {
                result += item.Price; //普通商品直接相加
            }

            var VIPItemList = order.Items.GetVIPItems();
            foreach (var item in VIPItemList)
            {
                result += item.Price + 20; //vip商品统一下调了20元，所以需要加上
            }

            return result;
        }

        public double GetVipPrice(Order order)
        {
            double result = 0.0;

            var VIPItemList = order.Items.GetVIPItems();
            foreach (var item in VIPItemList)
            {
                result += item.Price + 20; //vip商品统一下调了20元，所以需要加上
            }

            return result;

        }

    }
}
