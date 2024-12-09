using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F__Adapter
{
    internal class PaiementParPaypal : IPaiement
    {
        public void Payer(decimal montant)
        {
            Console.WriteLine($"Paiement de {montant}€ effectue par Paypal.");
        }
    }
}
