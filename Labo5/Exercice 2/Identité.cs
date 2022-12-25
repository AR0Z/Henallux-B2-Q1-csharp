namespace Labo5.Exercice_2
{
    public class Identité
    {
        private string nom;
        private string prénom;

        public Identité(string prénom, string nom)
        {
            this.nom = nom;
            this.prénom = prénom;
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Prénom
        {
            get
            {
                return prénom;
            }
        }

        public override string ToString()
        {
            return $"{Prénom}, {Nom}";
        }
    }
}