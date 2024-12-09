using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G__Decorator
{
    // Class abstraite dial Decorator
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee decoratedCoffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            this.decoratedCoffee = coffee;
        }

        public virtual string GetDescription()
        {
            return decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedCoffee.GetCost();
        }
    }
}
