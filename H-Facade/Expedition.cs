using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Facade
{
    internal class Expedition
    {
        public void ExpédierProduit(string produit)
        {
            Console.WriteLine($"Expedition de {produit} ...");
        }
    }
}
