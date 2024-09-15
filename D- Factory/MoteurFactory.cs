namespace D__Factory
{
    public class MoteurFactory
    {
        public static readonly int MOTEUR_DIESEL = 1;
        public static readonly int MOTEUR_ESSENCE = 2;
        public static Moteur? GetInstance(int Type) 
        { 
            if(Type == MOTEUR_DIESEL)
            {
                return new MoteurDiesel();
            }
            else if(Type == MOTEUR_ESSENCE)
            {
                return new MoteurEssence();
            }
            
            return null; 
        }
    }
}
