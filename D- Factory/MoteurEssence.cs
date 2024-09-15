namespace D__Factory
{
    public class MoteurEssence : Moteur
    {

        public MoteurEssence()
        {
            TypeCarburant = "Essence";
        }

        public override void Demarrer()
        {
            Console.WriteLine("Le moteur à essence démarre.");
        }
    }
}
