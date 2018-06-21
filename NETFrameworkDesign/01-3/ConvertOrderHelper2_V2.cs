using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public class ConvertOrderHelper2_V2:ConvertOrderHelper2
    {
        protected override Item BuildVipItemWithNormal(Item item)
        {
            var vipItem= base.BuildVipItemWithNormal(item);
            vipItem.Price = +10;//新版本的转换中需要加10块钱
            return vipItem;
        }

        protected override bool ValidatorConvertNormalOrder(Order normalOrder)
        {
            if (base.ValidatorConvertNormalOrder(normalOrder))
            {
                if (normalOrder.Status == 2) //新版本的转换中订单的状态必须是2才能满足验证
                {
                    return true;
                }
            }
            return false;
        }
    }
}
