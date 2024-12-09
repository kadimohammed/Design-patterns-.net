using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G__Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.decoratedCoffee.GetDescription() + ", m3a sukkar";
        }

        public override double GetCost()
        {
            return base.decoratedCoffee.GetCost() + 2.0;
        }
    }
}
