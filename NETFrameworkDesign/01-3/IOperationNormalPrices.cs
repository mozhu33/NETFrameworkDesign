using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public interface IOperationNormalPrices
    {
        double GetPrices(Order order);
        double GetVipPrice(Order order);
    }
}
