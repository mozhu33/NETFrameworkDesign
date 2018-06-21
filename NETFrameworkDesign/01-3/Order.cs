using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3
{
    public class Order
    {
        public int Status { get; set; }
        public Items Items { get; set; }

        public IOperationNormalPrices OperationPrices;
        public Order(IOperationNormalPrices operationPrices)
        {
            this.OperationPrices = operationPrices;
        }

        public double GetPrices()
        {
            return this.OperationPrices.GetPrices(this);
        }
    }
}
