using System;

namespace Labo3
{
    public class Marchand : PNJ
    {
        private ICompagnon[] compagnonsAVendre;

        public Marchand(string nom) : base(nom, 10, "commerçants")
        {
            compagnonsAVendre = new ICompagnon[10];
        }

        public int NbrCompagnon
        {
            get
            {
                int i = 0;
            
                while (compagnonsAVendre[i] != null)
                {
                    i++;
                }

                return i;
            }
            
        }

        public void AjouteCompagnon(ICompagnon compagnon)
        {
            compagnonsAVendre[NbrCompagnon] = compagnon;
        }

        public void AjouteCompagnon(params ICompagnon[] compagnon)
        {
            Array.Copy(compagnon, 0, compagnonsAVendre,NbrCompagnon, compagnon.Length);
        }
        public void AfficheOffre()
        {
            Console.WriteLine(Nom + " propose :");
            int i = 1;
            foreach (ICompagnon compagnon in compagnonsAVendre)
            {
                if (compagnon is ICompagnon)
                {
                    Console.WriteLine($"({i}) {compagnon.Nom} : {compagnon.PrixAchat} po {(compagnon.CoûtQuotidien != 0 ? $"plus {compagnon.CoûtQuotidien} po par jour"  : "" )}");
                    i++;
                }
            }
        }
    }
}