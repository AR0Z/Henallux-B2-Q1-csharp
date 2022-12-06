namespace Labo3
{
    public class DessinAnimé : ÉpisodeSérie
    {
        private int âgeCible;

        public DessinAnimé(string titre, int durée, string titreSérie, int numÉpisode, int âgeCible) : base(titre,
            durée, titreSérie, numÉpisode)
        {
            this.âgeCible = âgeCible;
        }

        public new string Présentation()
        {
            return $"Enfants de {âgeCible} ans : {titre} ({titreSérie} numéro {numÉpisode})";
        }
    }
}