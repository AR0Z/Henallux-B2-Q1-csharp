namespace Labo4
{
    public class Travailleur : Inscrit
    {
        private string métier;
        protected Institution institution;

        public Travailleur(string nom, int codePostal, Formation formation, string métier, Institution institution = null) : base(nom, codePostal, formation)
        {
            this.métier = métier;
            this.institution = institution;
        }
        
        public virtual string Occupation()
        {
            return $"{(institution != null ? "employé chez " + institution.Nom + "\n" : "")} {métier}";
        }

        public override int PourcRéductionBase
        {
            get
            {
                if(institution != null)
                    return Utilitaires.GrandNamur(institution.CodePostal) ? 20 : 0;
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {(institution != null ? $"employé chez {institution.Nom} ({institution.CodePostal})" : métier)}";
        }
    }
}