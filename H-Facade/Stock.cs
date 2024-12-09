using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Facade
{
    internal class Stock
    {
        public void VerifierDisponibilite(string produit)
        {
            Console.WriteLine($"verification de la disponibilite de {produit}...");
        }
    }
}
