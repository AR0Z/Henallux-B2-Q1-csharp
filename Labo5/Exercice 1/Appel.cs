using System;

namespace Labo5.Exercice_1
{
    public class Appel : IComparable
    {
        private string nom;
        private string téléphone;

        public Appel(string nom, string téléphone)
        {
            this.nom = nom;
            this.téléphone = téléphone;
        }

        public int CompareTo(Object o)
        {
            if (o == null) return 1;

            Appel appel = o as Appel;

            if (appel != null)
            {
                if (this.téléphone == appel.téléphone)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{nom} ({téléphone})";
        }
    }
}