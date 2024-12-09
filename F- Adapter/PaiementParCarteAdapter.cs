using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F__Adapter
{
    internal class PaiementParCarteAdapter : IPaiement
    {
        private readonly PaiementParCarte _paiementParCarte;

        public PaiementParCarteAdapter(PaiementParCarte paiementParCarte)
        {
            _paiementParCarte = paiementParCarte;
        }

        public void Payer(decimal montant)
        {
            _paiementParCarte.PayerParCarte(montant); // Appel de la méthode incompatible via ladaptateur
        }
    }
}
