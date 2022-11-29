namespace Labo3
{
    public class Mercenaire : PNJ, ICompagnon
    {
        public Mercenaire(string nom, int PvMax) : base(nom, PvMax, "alliés")
        {
            
        }

        public int CoûtQuotidien
        {
            get
            {
                if (PvMax <= 5)
                    return 25;
                if (PvMax <= 15)
                    return 35;

                return 35 + (PvMax - 15) * 2;
            }
        }

        public int PrixAchat
        {
            get
            {
                return PvMax * 7;
            }
        }
    }
}