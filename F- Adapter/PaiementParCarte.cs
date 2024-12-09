using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F__Adapter
{
    internal class PaiementParCarte
    {
        public void PayerParCarte(decimal montant)
        {
            Console.WriteLine($"Paiement de {montant}€ effectué par carte bancaire.");
        }
    }
}
