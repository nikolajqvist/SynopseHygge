using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiStrategySOLID
{
    public class UseOfStrategy
    {
        private NoDiscount _discountStrategy;

        public UseOfStrategy(NoDiscount discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public double DiscountStrategy(double price)
        {
            return _discountStrategy.CalcDiscount(price);
        }
    }
}
