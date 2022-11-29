namespace Labo3
{
    public class Familier : PNJ, ICompagnon
    {
        private int prix;

        public Familier(string nom, string description, int prix) : base(nom, 1, 1, "alliés")
        {
            Description = description;
            Prix = prix;
        }
        
        public string Description { get; set; }

        public int Prix
        {
            get
            {
                return prix;
            }

            set
            {
                if (value >= 0)
                    prix = value;
            }
        }
        
        public override int Pv
        {
            get { return base.Pv; }
            set { base.Pv = 1; }
        }

        public int PrixAchat
        {
            get
            {
                return Prix;
            }
        }

        public int CoûtQuotidien
        { get; }
    }
}