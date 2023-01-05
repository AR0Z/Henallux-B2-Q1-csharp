using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labo6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Des tableaux
            List<int> nombres = new List<int> { 7, 9, 13, 16, 21, 22, 29, 36, 44, 47, 51, 55, 64, 71,
                77, 81, 99 };
            char[] voyelles = { 'a', 'e', 'i', 'o', 'u', 'y' };
            // Une collection simple via List
            List<string> prénoms = new List<string>{ "Anatole", "Bergamote", "Cunégonde", "Doriphore",
                "Fernande", "Gustave", "Hermione", "Isidore", "Mathilde", "Ophélie",
                "Quasimodo", "Raistlin", "Wilfred", "Zénobe" };
            // Un tableau associatif via Dictionary
            Dictionary<int, List<string>> dico = new Dictionary<int, List<string>>();
            string[] nombresFr = { "un", "deux", "trois", "quatre", "cinq", "six",
                "sept", "huit", "neuf", "dix" };
            string[] nombresEn = { "one", "two", "three", "four", "five", "six",
                "seven", "eight", "nine", "ten" };
            for (int i = 1; i < 10; i++) {
                dico[i] = new List<string>();
                dico[i].Add(nombresFr[i - 1]);
                dico[i].Add(nombresEn[i - 1]);
            }
            Console.WriteLine(Affichage(prénoms));
            Console.WriteLine(Affichage(prénoms.Where(s => s.Length == 7)));
            
            Console.WriteLine(Affichage(prénoms.Where(s => s.Count(c => c == 'i') != 0)));
            
            Console.WriteLine(Affichage(prénoms.Where(s => ( s.CompareTo("C") < 0 || s.CompareTo("Sharp") > 0) )));
            
            Console.WriteLine(Affichage(prénoms.Where(s => s.Length == 7).Select(s => s.ToUpper())));
            
            Console.WriteLine(Affichage(prénoms.Select(s => s.Substring(1))));
            
            Console.WriteLine(Affichage(prénoms.SelectMany(s => s)
                                                    .Where(c => voyelles.Contains(c))
                                                    .Select(c => ((int)c).ToString())));
            
            Console.WriteLine(Affichage(nombres.Where(n => n % 2 == 0).Select(n => n.ToString())));
            
            int firstMultipleOf11 = nombres.FirstOrDefault(n => n % 11 == 0);
            
            Console.WriteLine(Affichage(nombres.Skip(nombres.IndexOf(firstMultipleOf11)).Select(n => n.ToString())));
            
            Console.WriteLine(Affichage(nombres.Select(n => n % 10).Select(n => n.ToString())));
            
        }
        
        static string Affichage(IEnumerable<string> valeurs)
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            bool premier = true;
            foreach (string val in valeurs)
            {
                if (!premier)
                    res.Append(", ");
                else
                    premier = false;
                res.Append(val);
            }
            res.Append("]");
            return res.ToString();
        }
        
    }
}