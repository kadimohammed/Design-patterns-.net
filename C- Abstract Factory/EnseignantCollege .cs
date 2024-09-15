namespace C__Abstract_Factory
{
    public class EnseignantCollege :IEnseignant
    {
        public string Nom { get; set; }
        public string MatiereEnseignee { get; set; }

        // Implémentation de la méthode de l'interface
        public void AfficherDetails()
        {
            Console.WriteLine($"Enseignant de collège - Nom: {Nom}, Matière enseignée: {MatiereEnseignee}");
        }
    }
}
