using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiStrategySOLID
{
    public class VIPDiscount:IDiscountStrategy
    {
        public double CalcDiscount(double price)
        {
            double discount = 0.50;
            return price *= discount;
        }
    }
}
