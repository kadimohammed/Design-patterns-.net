using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G__Decorator
{
    // Class concrete li kaytimplimenta l'interface
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Café simple";
        }

        public double GetCost()
        {
            return 10.0;
        }
    }
}
