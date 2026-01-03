using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiStrategySOLID
{
    public abstract class NoDiscount : IDiscountStrategy
    {
        public double CalcDiscount(double price)
        {
            return price;
        }
    }
}
