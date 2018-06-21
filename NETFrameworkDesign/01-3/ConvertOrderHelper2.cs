using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public class ConvertOrderHelper2
    {
        public virtual Order ConvertVipOrder(Order normalOrder)
        {
            if (this.ValidatorConvertNormalOrder(normalOrder))
                return null;
            Order result = new Order(new OperationNormalPrices())//normalOrder.OperationPrices)
            {
                Status = normalOrder.Status,
                Items = new Items()
            };

            normalOrder.Items.ForEach(item =>
                {

                    result.Items.Add(this.BuildVipItemWithNormal(item));
                });

            return result;
        }

        protected virtual bool ValidatorConvertNormalOrder(Order normalOrder)
        {
            if (normalOrder == null || normalOrder.Items == null || normalOrder.Items.Count == 0)
                return false;
            return true;
        }

        protected virtual Item BuildVipItemWithNormal(Item item)
        {
            Item result = new Item()
            {
                ItemCode = item.ItemCode,
                ItemName = item.ItemName,
                Price = item.Price - 20  //会员价要减掉20元
            };
            return result;
        }
    }
}
