namespace Labo3
{
    public class Créature
    {
        private string nom;
        private int pv;
        private int pvMax;

        public Créature(string nom, int pv, int pvMax)
        {
            Nom = nom;
            PvMax = pvMax;
            Pv = pv;
        }
        public Créature(string nom, int pvMax) : this(nom, pvMax, pvMax) { } 
        
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public virtual int Pv
        {
            get
            {
                return pv;
            }
            set
            {
                if (0 <= value && value <= pvMax)
                {
                    pv = value;
                }

                if (value < 0)
                    pv = 0;
                if (pvMax < value)
                    pv = pvMax;
            }
        }

        public int PvMax
        {
            get
            {
                return pvMax;
            }
            set
            {
                if (value < 1)
                {
                    pvMax = 1;
                }
                else
                {
                    pvMax = value;
                }
            }
        }

        public double PourcentsPV
        {
            get
            {
                return pv * 100 / (double) pvMax;
            }
        }

        public string État
        {
            get
            {
                return $"{Nom} ({Pv}/{PvMax}: {PourcentsPV.ToString("F2")}%) {(pv == 0 ? "- MORT" : "")}";
            }
        }
    }
}