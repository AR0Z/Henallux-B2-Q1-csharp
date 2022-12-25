using System;

namespace Labo5.Exercice_2
{
    public class Personne
    {
        protected Identité identité;
        private int âge;
        
        public Personne(Identité identité, int âge)
        {
            this.identité = identité;
            this.âge = âge;
        }

        public int Âge
        {
            get
            {
                return âge;
            }
        }

        public override string ToString()
        {
            return $"{identité} ({Âge})";
        }
    }
}