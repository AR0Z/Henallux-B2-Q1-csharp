namespace Labo3
{
    public class Film : Émission
    {
        private string genre;
        public Film(string titre, int durée, string genre) : base(titre, durée)
        {
            this.genre = genre;
        }

        public override string Présentation()
        {
            return base.Présentation() + ", " + genre;
        }
    }
}