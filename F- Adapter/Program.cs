using F__Adapter;

PaiementParCarte paiementCarte = new PaiementParCarte();
PaiementParPaypal paiementPaypal = new PaiementParPaypal();

IPaiement paiement = new PaiementParCarteAdapter(paiementCarte);

paiementPaypal.Payer(150.00m);
paiement.Payer(100.50m);