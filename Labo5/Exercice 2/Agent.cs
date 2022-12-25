using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labo5.Exercice_2
{
    public class Agent : Personne
    {
        private HashSet<Informateur> contacts;
        
        public Agent(Identité identité, int âge) : base(identité, âge)
        {
            contacts = new HashSet<Informateur>();
        }

        public void AjouteInformateur(Informateur inf)
        {
            if (!contacts.Contains(inf))
            {
                contacts.Add(inf);
            }
        }

        public bool ConnaîtInformateur(Informateur inf)
        {
            return contacts.Contains(inf);
        }
        
        public override string ToString()
        {
            StringBuilder output = new StringBuilder($"{base.ToString()}");

            if (contacts.Any())
            {
                foreach (Informateur contact in contacts)
                {
                    output.Append($"{Environment.NewLine}- {contact}");
                }
            }
            else
            {
                output.Append($"{Environment.NewLine}Aucun contact");
            }
            return output.ToString();
        }

        public Identité Identité
        {
            get
            {
                return identité;
            }
        }
    }
}