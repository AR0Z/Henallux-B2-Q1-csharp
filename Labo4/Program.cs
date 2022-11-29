using System;

namespace Labo4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Formation formation1 = new Formation("JSC007", "Introduction à Javascript", 100, false);
            Formation formation2 = new Formation("NET042", "Trouver l’info sur internet ", 100);
            Formation formation3 = new Formation("UML042", "UML pour les nuls", 100);
            Console.WriteLine(formation1);
            Console.WriteLine(formation2);

            Travailleur travailleur1 = new Travailleur("Germain Duchêne", 6300, formation1, "indépendant");

            travailleur1.AjoutFormations(formation2, formation3);
            Console.WriteLine(travailleur1.FicheInformations());

            Chômeur chomeur1 = new Chômeur("Calvin Nogueira", 5100, formation1, 01);
            chomeur1.AjoutFormations(formation2, formation3);
            Console.WriteLine(chomeur1.FicheInformations());
            
            Chômeur chomeur2 = new Chômeur("Alexandre Godi", 6300, formation1, 02);
            chomeur1.AjoutFormations(formation2);
            Console.WriteLine(chomeur2.FicheInformations());
            
            Institution institution1 = new Institution("Hénallux", 5100);
            Enseignant enseignant1 = new Enseignant("Christophe Bernard", 5100, formation1, "orienté objet", institution1); 
            enseignant1.AjoutFormations(formation2, formation3);
            Console.WriteLine(enseignant1.FicheInformations());
        }
    }
}