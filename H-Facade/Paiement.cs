using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Facade
{
    internal class Paiement
    {
        public void EffectuerPaiement(decimal montant)
        {
            Console.WriteLine($"Paiement de {montant} effectue.");
        }
    }
}
