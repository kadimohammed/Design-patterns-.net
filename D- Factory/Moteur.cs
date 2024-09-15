namespace D__Factory
{
    public abstract class Moteur
    {
        public string? TypeCarburant { get; set; } 
        public abstract void Demarrer();

        public void Arreter()
        {
            Console.WriteLine("Le moteur est arrêté.");
        }
    }
}
