namespace D__Factory
{
    public class MoteurDiesel : Moteur
    {
        public MoteurDiesel()
        {
            TypeCarburant = "Diesel";
        }
        public override void Demarrer()
        {
            Console.WriteLine("Le moteur diesel démarre.");
        }
    }
}
