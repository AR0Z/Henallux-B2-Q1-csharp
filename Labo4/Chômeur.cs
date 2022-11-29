namespace Labo4
{
    public class Chômeur : Inscrit
    {
        private int numONEM;

        public Chômeur(string nom, int codePostal, Formation formation, int numONEM) : base(nom, codePostal, formation)
        {
            this.numONEM = numONEM;
        }

        public override int PourcRéductionBase
        {
            get
            {
                return 100;
            }
        }
    }
}