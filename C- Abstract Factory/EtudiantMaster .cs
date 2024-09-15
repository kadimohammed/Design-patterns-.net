namespace C__Abstract_Factory
{
    public class EtudiantMaster :IEtudient
    {
        public string Nom { get; set; }
        public string Programme { get; set; }

        public void AfficherDetails()
        {
            Console.WriteLine($"Étudiant de master - Nom: {Nom}, Programme: {Programme}");
        }
    }
}
