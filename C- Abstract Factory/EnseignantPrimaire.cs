namespace C__Abstract_Factory
{
    public class EnseignantPrimaire :IEnseignant
    {
        public string Nom { get; set; }
        public string NiveauEnseignement { get; set; }

        public void AfficherDetails()
        {
            Console.WriteLine($"Enseignant de primaire - Nom: {Nom}, Niveau d'enseignement: {NiveauEnseignement}");
        }
    }
}
