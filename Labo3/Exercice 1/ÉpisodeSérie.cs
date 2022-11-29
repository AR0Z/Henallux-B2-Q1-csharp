namespace Labo3
{
    public class ÉpisodeSérie : Émission
    {
        protected string titreSérie;
        protected int numÉpisode;

        public ÉpisodeSérie(string titre, int durée, string titreSérie, int numÉpisode) : base(titre, durée)
        {
            this.titreSérie = titreSérie;
            this.numÉpisode = numÉpisode;
        }

        public override string Présentation()
        {
            return titreSérie + " : " + titre + " (" + durée + ")";
        }
    }
}