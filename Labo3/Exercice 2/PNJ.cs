namespace Labo3
{
    public class PNJ : Créature
    {
        public PNJ(string nom, int pv, int pvMax, string faction) : base(nom, pv, pvMax)
        {
            Faction = faction;
        }
        
        public PNJ(string nom, int pvMax, string faction) : base(nom, pvMax)
        {
            Faction = faction;
        }
        public string Faction { get; set; }

    }
}