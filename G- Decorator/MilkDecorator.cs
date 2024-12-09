using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G__Decorator
{
    // Decorators concrets
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.decoratedCoffee.GetDescription() + ", m3a 7lib";
        }

        public override double GetCost()
        {
            return base.decoratedCoffee.GetCost() + 5.0;
        }
    }
}
