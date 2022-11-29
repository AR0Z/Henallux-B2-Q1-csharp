namespace Labo3
{
    public class Émission
    {
        protected string titre;
        protected int durée;

        public Émission(string titre, int durée)
        {
            this.titre = titre;
            this.durée = durée;
        }

        public virtual string Présentation()
        {
            return titre + " (" + durée + " minutes)";
        }
    }
}