using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public class ConvertOrderHelper1
    {
        public Order ConvertVipOrder(Order normalOrder)
        {
            if (normalOrder == null || normalOrder.Items == null || normalOrder.Items.Count == 0)
                return null;
            Order result = new Order(new OperationNormalPrices())//normalOrder.OperationPrices)
            {
                Status = normalOrder.Status,
                Items = new Items()
            };

            normalOrder.Items.ForEach(item =>
                {
                    result.Items.Add(new Item()
                        {
                            ItemCode = item.ItemCode,
                            ItemName = item.ItemName,
                            Price = item.Price - 20
                        });
                });

            return result;
        }
    }
}
