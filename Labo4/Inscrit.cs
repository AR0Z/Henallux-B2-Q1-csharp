using System;

namespace Labo4
{
    public abstract class Inscrit
    {
        public const int NB_MAX_FORMATIONS_SUIVIES = 5;

        private string nom;
        private int codePostal;
        private Formation formationPrincipale;
        private Formation[] formationsInscrites;

        public Inscrit(string nom, int codePostal, Formation formation)
        {
            this.nom = nom;
            this.codePostal = codePostal;
            if(formation == null)
                throw new Exception("Il faut une formation principale !");

            formationPrincipale = formation;
            formationsInscrites = new Formation[NB_MAX_FORMATIONS_SUIVIES];

            formationsInscrites[0] = formation;
        }
        
        public int NbrInscription()
        {
            int i = 0;
            
            while (formationsInscrites[i] != null)
            {
                i++;
            }

            return i;
        }

        public string FormationPrincipale
        {
            get
            {
                return formationPrincipale.Code;
            }
            set
            {
                foreach (Formation formation in formationsInscrites)
                {
                    if (formation.Code == value)
                    {
                        formationPrincipale = formation;
                    }
                }
            }
        }

        public bool estDejaInscrit(Formation formation)
        {

            return Array.IndexOf(formationsInscrites, formation) != -1;
        }

        public void AjoutFormation(Formation formation, bool formationPrincipale=false)
        {
            if (NbrInscription() < 5 && formation.NbrInscrit() < 25 && !estDejaInscrit(formation))
            {
                formationsInscrites[NbrInscription()] = formation;
                formation.ajoutParticipant(this);
            }

            if (estDejaInscrit(formation))
            {
                if (formationPrincipale)
                    this.formationPrincipale = formation;
            }
        }

        public void AjoutFormations(params Formation[] formations)
        {
            foreach (Formation formation in formations)
            {
                AjoutFormation(formation);
            }
        }

        public abstract int PourcRéductionBase
        {
            get;
        }

        public double Coût(Formation formation)
        {
            int réduction = PourcRéductionBase;

            if (formation.EstSponsoriséRW && Utilitaires.RegionWallonne(codePostal))
            {
                réduction += 25;

                if (réduction > 100)
                    réduction = 100;
            }
            return formation.Prix * (1 - (double) réduction/100);
        }

        public double CoûtTotal()
        {
            double coûtTotal = 0;

            foreach (Formation formation in formationsInscrites)
            {
                if(formation != null)
                    coûtTotal += Coût(formation);
            }

            return coûtTotal;
        }

        public string FicheInformations()
        {
            string fiche = "Inscrit : " + this + "\n";

            foreach (Formation formation in formationsInscrites)
            {
                if(formation != null)
                    fiche += formation.Informations + "\n";
            }

            fiche += "Total à payer : " + CoûtTotal() + "Euros ";

            return fiche;
        }
        
        public override string ToString()
        {
            return nom + " (" + codePostal + ")";
        }
    }
}