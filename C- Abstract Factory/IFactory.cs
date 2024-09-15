namespace C__Abstract_Factory
{
    public interface IFactory
    {
        IEtudient? CreerEtudiant(int a);
        IEnseignant? CreerEnseignant(int a);
    }
}
