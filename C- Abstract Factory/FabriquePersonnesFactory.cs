namespace C__Abstract_Factory
{
    public class FabriquePersonnesFactory : IFactory
    {
        public static readonly int ENS_PRIMAIRE = 1;
        public static readonly int ENS_COLLEGE = 2;
        public static readonly int ETU_MASTER = 1;
        public static readonly int ETU_LICENCE = 2;
        public IEtudient? CreerEtudiant(int type)
        {
            if(type == ETU_LICENCE)
            {
                return new EtudiantLicence();
            }
            else if(type == ETU_MASTER)
            {
                return new EtudiantMaster();
            }
            return null;
        }

        public IEnseignant? CreerEnseignant(int type)
        {
            if (type == ENS_COLLEGE)
            {
                return new EnseignantCollege();
            }
            else if (type == ENS_PRIMAIRE)
            {
                return new EnseignantPrimaire();
            }
            return null;
        }

    }
}
