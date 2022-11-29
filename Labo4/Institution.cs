namespace Labo4
{
    public class Institution
    {
        private string nom;
        private int codePostal;

        public Institution(string nom, int codePostal)
        {
            this.nom = nom;
            this.codePostal = codePostal;
        }
        
        public string Nom { get; }
        public int CodePostal { get; }
    }
}