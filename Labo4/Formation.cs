namespace Labo4
{
    public class Formation
    {
        #region attributes
        public const int NB_MAX_PLACES = 25;
        
        private string code;
        private string libellé;
        private double prix;
        private Inscrit[] personnesInscrites;
        private bool estSponsoriséRW;
        #endregion

        public Formation(string code, string libellé, int prix, bool estSponsoriséRw = true)
        {
            this.code = code;
            this.libellé = libellé;
            Prix = prix;
            this.estSponsoriséRW = estSponsoriséRw;

            personnesInscrites = new Inscrit[NB_MAX_PLACES];
        }
        public string Code { get; }
        public double Prix
        {
            get
            {
                return prix;
            }
            set
            {
                if (100 <= value)
                {
                    prix = value;
                }
                else
                {
                    prix = 100;
                }
            }
        }

        public bool EstSponsoriséRW
        {
            get
            {
                return estSponsoriséRW;
            }
        }

        public string Informations
        {
            get
            {
                return code + " - " + libellé + (estSponsoriséRW ? "(RW)" : "");
            }
        }

        public void ajoutParticipant(Inscrit participant)
        {
            personnesInscrites[NbrInscrit()] = participant;
        }
        
        public int NbrInscrit()
        {
            int i = 0;
            
            while (personnesInscrites[i] != null)
            {
                i++;
            }

            return i;
        }

        public override string ToString()
        {
            return code + " - " + libellé + (estSponsoriséRW ? "(RW)" : "") + " [" + NbrInscrit() + " inscrit(s)]";
        }
    }
}