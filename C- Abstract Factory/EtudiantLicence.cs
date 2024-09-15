namespace C__Abstract_Factory
{
    public class EtudiantLicence : IEtudient
    {
        public string Nom { get; set; }
        public string Niveau { get; set; }

        public void AfficherDetails()
        {
            Console.WriteLine($"Étudiant de licence - Nom: {Nom}, Niveau: {Niveau}");
        }
    }
}
