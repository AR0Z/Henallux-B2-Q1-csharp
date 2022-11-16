using System;

namespace Labo1Player 
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            Player germain = new Player("Germain", "Duchêne", new DateTime(2001, 09, 24), false);
            
            TestMaps();
        }
        
        public static void TestMaps() 
        {
            // Mise en place
            Player p = new Player("Indiana", "Jones", new DateTime(1899,7,1));
            // Test
            AssertMaps("aucune", p);
            // Mise en place
            Map canyon = new Map("Canyon", 100, true);
            Map forteresse = new Map("Forteresse", 100, true);
            Map foret = new Map("Forêt", 100, true);
            Map desert = new Map("Desert", 100, false);
            Map oasis = new Map("Oasis", 100, true);
            Map caverne = new Map("Caverne", 100, true);
            
            p.AddMap(canyon);
            // Test
            AssertMaps("Canyon", p);
            // Mise en place
            p.AddMap(forteresse);
            p.AddMap(foret);
            // Test
            AssertMaps("Forêt, Forteresse, Canyon", p);
            // Mise en place
            p.AddMap(forteresse);
            // Test
            AssertMaps("Forteresse, Forêt, Canyon", p);
            // Mise en place
            p.AddMap(desert);
            p.AddMap(oasis);
            // Test
            AssertMaps("Oasis, Desert, Forteresse, Forêt, Canyon", p);
            // Mise en place
            p.AddMap(foret);
            // Test
            AssertMaps("Forêt, Oasis, Desert, Forteresse, Canyon", p);
            // Mise en place
            p.AddMap(caverne);
            // Test
            AssertMaps("Caverne, Forêt, Oasis, Desert, Forteresse", p);
            
            caverne.Description();
        }
        
        public static void AssertMaps(string expected, Player p)
        {
            Console.WriteLine("Expected answer : " + expected);
            Console.WriteLine(p.ListingMaps());
        }
    }
}