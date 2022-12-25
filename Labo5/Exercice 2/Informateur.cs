using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labo5.Exercice_2
{
    public class Informateur : Personne
    {
        private HashSet<string> domaines;

        public Informateur(Identité identité, int âge) : base(identité, âge)
        {
            domaines = new HashSet<string>();
        }

        public void AjouteDomaine(string domaine)
        {
            domaine = domaine.ToLower();
            if (!domaines.Contains(domaine))
            {
                domaines.Add(domaine);
            }
        }

        public bool ConnaîtDomaine(string domaine)
        {
            domaine = domaine.ToLower();
            return domaines.Contains(domaine);
        }

        public void AfficheDomaines()
        {
            Console.Write($"{identité} connait :");
            if (domaines.Any())
            {
                foreach (string domaine in domaines)
                {
                    Console.Write($" {domaine}");
                }
            }
            else
            {
                Console.Write(" Aucun domaine");
            }
            Console.WriteLine(".");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder($"{base.ToString()}");
            output.Append($" [");
            
            if (domaines.Any())
            {
                int i = 1;
                foreach (string domaine in domaines)
                {
                    if(i != domaines.Count)
                        output.Append($"{domaine}, ");
                    else
                        output.Append($"{domaine}");

                    i++;
                }
            }
            else
            {
                output.Append("Aucun domaine");
            }
            output.Append("]");
            return output.ToString();
        }
    }
}