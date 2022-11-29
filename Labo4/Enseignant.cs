using System;

namespace Labo4
{
    public class Enseignant : Travailleur
    {
        private string domaine;

        public Enseignant(string nom, int codePostal, Formation formation, string domaine, Institution institution) :
            base(nom, codePostal, formation, "Enseignant", institution)
        {
            this.domaine = domaine;
            
            if(institution == null)
                throw new Exception("Il faut une institution !");
        }

        public override string Occupation()
        {
            return "enseignant chez " + institution.Nom + " - [Domaine : " + domaine + "]";
        }

        public override int PourcRéductionBase
        {
            get
            {
                return 50 + (Utilitaires.GrandNamur(institution.CodePostal) ? 20 : 0);
            }
        }
    }
}