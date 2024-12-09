using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Facade
{
    internal class GestionCommandeFacade
    {
        private readonly Stock _stock;
        private readonly Paiement _paiement;
        private readonly Expedition _expedition;

        public GestionCommandeFacade()
        {
            _stock = new Stock();
            _paiement = new Paiement();
            _expedition = new Expedition();
        }

        // Methode simplifieer pour traiter une commande
        public void TraiterCommande(string produit, decimal montant)
        {
            _stock.VerifierDisponibilite(produit);
            _paiement.EffectuerPaiement(montant);
            _expedition.ExpédierProduit(produit);
        }
    }
}
