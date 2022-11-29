using System;

namespace Labo3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Émission e1 = new Émission("Motus", 50);
            Émission e2 = new Émission("Des chiffres et des lettres", 45);
            Film f1 = new Film("Bilbo the Hobbit", 182, "fantastique");
            Film f2 = new Film("Le bon, la brute et le truand", 178, "western");
            ÉpisodeSérie s1 = new ÉpisodeSérie("Monsters", 47, "The Walking Dead", 801);
            ÉpisodeSérie s2 = new ÉpisodeSérie("The Interrogation", 52, "Designated Survivor", 6);
            DessinAnimé da1 = new DessinAnimé("Simprovised", 24, "Simpsons", 2721,
                16);
            DessinAnimé da2 = new DessinAnimé("Droids in Distress", 22, "Star Wars Rebels", 3, 8);
            UtilTV.AfficheProgramme(e1, e2, e2, f1, f2, s1, s2, da1, da2);
            Console.WriteLine("....");
            UtilTV.PrésenteDA(da1, da2);*/
            
            PNJ hubert = new PNJ("Hubert", 15, "commerçants");
            Familier abu = new Familier("Abu", "un petit singe", 20);
            Console.WriteLine(hubert.État);
            hubert.Pv -= 5;
            Console.WriteLine(hubert.État);
            hubert.Pv += 10;
            Console.WriteLine(hubert.État);
            Console.WriteLine(abu.État);
            abu.Pv -= 2;
            Console.WriteLine(abu.État);
            
            Marchand cunégonde = new Marchand("Cunégonde");
            cunégonde.AjouteCompagnon(abu);
            Mercenaire m1 = new Mercenaire("homme de main", 5);
            Mercenaire m2 = new Mercenaire("garde du corps", 12);
            Mercenaire m3 = new Mercenaire("vétéran", 20);
            cunégonde.AjouteCompagnon(m1, m2, m3);
            cunégonde.AfficheOffre();
        }
    }
}