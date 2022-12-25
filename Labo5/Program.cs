using System;
using Labo5.Exercice_1;
using Labo5.Exercice_2;

namespace Labo5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // // Todo<int> todo = new Todo<int>();
            // // Console.WriteLine("Ajout de 111, 222, 333, 444, 555, 666");
            // // todo.Ajoute(111);
            // // todo.Ajoute(222);
            // // todo.Ajoute(333);
            // // todo.Ajoute(444);
            // // todo.Ajoute(555);
            // // todo.Ajoute(666);
            // // todo.Ajoute(111);
            // // todo.Ajoute(222);
            // // Console.WriteLine("Lecture : " + todo.AppelLu());
            // // Console.WriteLine("Lecture : " + todo.AppelLu());
            // // Console.WriteLine("Ajout de 999");
            // // todo.Ajoute(999);
            // // while (!todo.EstVide())
            // // {
            // //     Console.WriteLine("Lecture : " + todo.AppelLu());
            // // }
            // // Console.WriteLine("Todo vide");
            //
            // // Todo<string> todo = new Todo<string>();
            // // Console.WriteLine("Ajout de 111, 222, 333, 444, 555, 666");
            // // todo.Ajoute("111");
            // // todo.Ajoute("222");
            // // todo.Ajoute("333");
            // // todo.Ajoute("444");
            // // todo.Ajoute("555");
            // // todo.Ajoute("666");
            // // Console.WriteLine("Lecture : " + todo.AppelLu());
            // // Console.WriteLine("Lecture : " + todo.AppelLu());
            // // Console.WriteLine("Ajout de 999");
            // // todo.Ajoute("999");
            // // while (!todo.EstVide())
            // // {
            // //     Console.WriteLine("Lecture : " + todo.AppelLu());
            // // }
            // // Console.WriteLine("Todo vide");
            //
            // Todo<Appel> todo = new Todo<Appel>();
            //
            // Appel a1 = new Appel("Ilove Ones", "111");
            // Appel a2 = new Appel("Parité Forever", "222");
            // Appel a3 = new Appel("Demy Daemon", "333");
            // Appel a4 = new Appel("Poule Chicken", "444");
            // Appel a5 = new Appel("Phone Number", "555");
            // Appel a6 = new Appel("L. A. Bête", "666");
            // Appel a9 = new Appel("Triple Ponte", "999");
            //
            // Console.WriteLine("Ajout de 111, 222, 333, 444, 555, 666");
            // todo.Ajoute(a1);
            // todo.Ajoute(a2);
            // todo.Ajoute(a3);
            // Appel a3bis = new Appel("Triple trois", "333");
            // todo.Ajoute(a3bis);
            // todo.Ajoute(a4);
            // todo.Ajoute(a5);
            // todo.Ajoute(a6);
            // Console.WriteLine("Lecture : " + todo.AppelLu());
            // Console.WriteLine("Lecture : " + todo.AppelLu());
            // Console.WriteLine("Ajout de 999");
            // todo.Ajoute(a9);
            // while (!todo.EstVide())
            // {
            //     Console.WriteLine("Lecture : " + todo.AppelLu());
            // }
            // Console.WriteLine("Todo vide");


            Chapitre c1 = new Chapitre("Manage");
            Agent c1aa0 = new Agent(new Identité("Natalie", "Mills"), 26);
            Informateur c1aa0i0 = new Informateur(new Identité("Carter", "Howard"),
            18);
            c1aa0i0.AjouteDomaine("crime organisé");
            c1aa0i0.AjouteDomaine("espionnage technique");
            c1aa0.AjouteInformateur(c1aa0i0);
            Informateur c1aa0i1 = new Informateur(new Identité("Grace", "Potter"),
            33);
            c1aa0i1.AjouteDomaine("crime organisé");
            c1aa0i1.AjouteDomaine("espionnage technique");
            c1aa0i1.AjouteDomaine("vente d'armes");
            c1aa0.AjouteInformateur(c1aa0i1);
            Informateur c1aa0i2 = new Informateur(new Identité("Evelyn", "Cox"), 41);
            c1aa0i2.AjouteDomaine("crime organisé");
            c1aa0.AjouteInformateur(c1aa0i2);
            c1.AjouteAgent(c1aa0);
            Agent c1aa1 = new Agent(new Identité("Peyton", "Davidson"), 23);
            Informateur c1aa1i0 = new Informateur(new Identité("Aiden", "Hopkins"),
            47);
            c1aa1i0.AjouteDomaine("mafia");
            c1aa1.AjouteInformateur(c1aa1i0);
            Informateur c1aa1i1 = new Informateur(new Identité("Kaylee", "Owens"),
            26);
            c1aa1i1.AjouteDomaine("cambriolages");
            c1aa1i1.AjouteDomaine("vente d'armes");
            c1aa1.AjouteInformateur(c1aa1i1);
            c1.AjouteAgent(c1aa1);
            Agent c1aa2 = new Agent(new Identité("Landon", "Alexander"), 30);
            Informateur c1aa2i0 = new Informateur(new Identité("Isaac", "Parker"),
            39);
            c1aa2i0.AjouteDomaine("espionnage technique");
            c1aa2i0.AjouteDomaine("mafia");
            c1aa2i0.AjouteDomaine("blanchiment d'argent");
            c1aa2.AjouteInformateur(c1aa2i0);
            Informateur c1aa2i1 = new Informateur(new Identité("Benjamin", "Duncan"),
            22);
            c1aa2i1.AjouteDomaine("racket");
            c1aa2i1.AjouteDomaine("vente d'armes");
            c1aa2.AjouteInformateur(c1aa2i1);
            Informateur c1aa2i2 = new Informateur(new Identité("Mason", "Miss"), 34);
            c1aa2i2.AjouteDomaine("crime organisé");
            c1aa2i2.AjouteDomaine("drogue");
            c1aa2i2.AjouteDomaine("vente d'armes");
            c1aa2.AjouteInformateur(c1aa2i2);
            c1.AjouteAgent(c1aa2);
            Agent c1aa3 = new Agent(new Identité("Hannah", "Mary"), 47);
            Informateur c1aa3i0 = new Informateur(new Identité("Hannah", "Murphy"),
            27);
            c1aa3i0.AjouteDomaine("contrebande");
            c1aa3i0.AjouteDomaine("drogue");
            c1aa3i0.AjouteDomaine("racket");
            c1aa3.AjouteInformateur(c1aa3i0);
            Informateur c1aa3i1 = new Informateur(new Identité("Brooklyn", "Page"),
            25);
            c1aa3i1.AjouteDomaine("pègre");
            c1aa3i1.AjouteDomaine("pègre");
            c1aa3i1.AjouteDomaine("espionnage technique");
            c1aa3.AjouteInformateur(c1aa3i1);
            c1.AjouteAgent(c1aa3);
            Agent c1aa4 = new Agent(new Identité("Julian", "Hicks"), 38);
            Informateur c1aa4i0 = new Informateur(new Identité("Liam", "Murray"),
            31);
            c1aa4i0.AjouteDomaine("mafia");
            c1aa4.AjouteInformateur(c1aa4i0);
            Informateur c1aa4i1 = new Informateur(new Identité("Christian",
            "Thomas"), 42);
            c1aa4i1.AjouteDomaine("blanchiment d'argent");
            c1aa4i1.AjouteDomaine("mafia");
            c1aa4i1.AjouteDomaine("mafia");
            c1aa4.AjouteInformateur(c1aa4i1);
            c1.AjouteAgent(c1aa4);
            c1.AjouteSafehouse("Genêt", "Ruelle Marique, 125");
            c1.AjouteSafehouse("Astrance", "Chemin de Bateau, 234");
            c1.AjouteSafehouse("Buglose", "Rue Tabaral, 357");
            c1.AjouteSafehouse("Saponaire", "Chemin Masy, 128");
            c1.AjouteSafehouse("Digitale", "Chemin de la Taille Boha, 331");
            c1.AjouteSafehouse("Myosotis", "Rue Quirin, 142");
            c1.AjouteSafehouse("Potentille", "Place Sainte-Sévère, 277");
            Agent c1m0a0 = new Agent(new Identité("Isaiah", "Island"), 28);
            Informateur c1m0a0i0 = new Informateur(new Identité("Daniel", "Mc"), 18);
            c1m0a0i0.AjouteDomaine("drogue");
            c1m0a0i0.AjouteDomaine("pègre");
            c1m0a0.AjouteInformateur(c1m0a0i0);
            Informateur c1m0a0i1 = new Informateur(new Identité("Mason", "Jackson"),
            22);
            c1m0a0i1.AjouteDomaine("drogue");
            c1m0a0i1.AjouteDomaine("mafia");
            c1m0a0i1.AjouteDomaine("contrebande");
            c1m0a0.AjouteInformateur(c1m0a0i1);
            Informateur c1m0a0i2 = new Informateur(new Identité("Addison",
            "Phillips"), 39);
            c1m0a0i2.AjouteDomaine("espionnage technique");
            c1m0a0.AjouteInformateur(c1m0a0i2);
            c1.AjouteAgentMission("Chicorée", c1m0a0);
            Agent c1m0a1 = new Agent(new Identité("Lincoln", "Bros"), 42);
            Informateur c1m0a1i0 = new Informateur(new Identité("Elena", "Watts"),
            31);
            c1m0a1i0.AjouteDomaine("vente d'armes");
            c1m0a1i0.AjouteDomaine("cambriolages");
            c1m0a1i0.AjouteDomaine("cambriolages");
            c1m0a1.AjouteInformateur(c1m0a1i0);
            Informateur c1m0a1i1 = new Informateur(new Identité("Grace", "Bryan"),
            39);
            c1m0a1i1.AjouteDomaine("mafia");
            c1m0a1.AjouteInformateur(c1m0a1i1);
            c1.AjouteAgentMission("Chicorée", c1m0a1);
            Agent c1m1a0 = new Agent(new Identité("Daniel", "Williamson"), 34);
            Informateur c1m1a0i0 = new Informateur(new Identité("Noah", "Robert"),
            22);
            c1m1a0i0.AjouteDomaine("espionnage technique");
            c1m1a0.AjouteInformateur(c1m1a0i0);
            Informateur c1m1a0i1 = new Informateur(new Identité("William", "Clay"),
            45);
            c1m1a0i1.AjouteDomaine("drogue");
            c1m1a0i1.AjouteDomaine("cambriolages");
            c1m1a0i1.AjouteDomaine("drogue");
            c1m1a0.AjouteInformateur(c1m1a0i1);
            Informateur c1m1a0i2 = new Informateur(new Identité("Grayson", "Perry"),
            31);
            c1m1a0i2.AjouteDomaine("blanchiment d'argent");
            c1m1a0.AjouteInformateur(c1m1a0i2);
            c1.AjouteAgentMission("Gentiane", c1m1a0);
            Agent c1m1a1 = new Agent(new Identité("Nora", "Bruce"), 24);
            Informateur c1m1a1i0 = new Informateur(new Identité("Oliver", "Sherman"),
            47);
            c1m1a1i0.AjouteDomaine("mafia");
            c1m1a1i0.AjouteDomaine("espionnage technique");
            c1m1a1i0.AjouteDomaine("vente d'armes");
            c1m1a1.AjouteInformateur(c1m1a1i0);
            Informateur c1m1a1i1 = new Informateur(new Identité("Liam", "Stanley"),
            33);
            c1m1a1i1.AjouteDomaine("mafia");
            c1m1a1.AjouteInformateur(c1m1a1i1);
            Informateur c1m1a1i2 = new Informateur(new Identité("Gabriel", "Watts"),
            47);
            c1m1a1i2.AjouteDomaine("racket");
            c1m1a1i2.AjouteDomaine("espionnage technique");
            c1m1a1.AjouteInformateur(c1m1a1i2);
            Informateur c1m1a1i3 = new Informateur(new Identité("Evelyn", "Page"),
            33);
            c1m1a1i3.AjouteDomaine("blanchiment d'argent");
            c1m1a1i3.AjouteDomaine("cambriolages");
            c1m1a1i3.AjouteDomaine("drogue");
            c1m1a1.AjouteInformateur(c1m1a1i3);
            Informateur c1m1a1i4 = new Informateur(new Identité("Owen", "Fleming"),
            44);
            c1m1a1i4.AjouteDomaine("blanchiment d'argent");
            c1m1a1i4.AjouteDomaine("vente d'armes");
            c1m1a1.AjouteInformateur(c1m1a1i4);
            Informateur c1m1a1i5 = new Informateur(new Identité("Sophia", "Dixon"),
            23);
            c1m1a1i5.AjouteDomaine("pègre");
            c1m1a1i5.AjouteDomaine("espionnage technique");
            c1m1a1.AjouteInformateur(c1m1a1i5);
            c1.AjouteAgentMission("Gentiane", c1m1a1);
            Agent c1m2a0 = new Agent(new Identité("Isaiah", "Crawford"), 34);
            Informateur c1m2a0i0 = new Informateur(new Identité("Dylan", "Lee"), 25);
            c1m2a0i0.AjouteDomaine("crime organisé");
            c1m2a0.AjouteInformateur(c1m2a0i0);
            Informateur c1m2a0i1 = new Informateur(new Identité("Abigail", "Morgan"),
            20);
            c1m2a0i1.AjouteDomaine("drogue");
            c1m2a0.AjouteInformateur(c1m2a0i1);
            Informateur c1m2a0i2 = new Informateur(new Identité("Carter", "Kelly"),
            41);
            c1m2a0i2.AjouteDomaine("contrebande");
            c1m2a0i2.AjouteDomaine("drogue");
            c1m2a0.AjouteInformateur(c1m2a0i2);
            Informateur c1m2a0i3 = new Informateur(new Identité("Andrew", "Bell"),
            35);
            c1m2a0i3.AjouteDomaine("blanchiment d'argent");
            c1m2a0i3.AjouteDomaine("cambriolages");
            c1m2a0i3.AjouteDomaine("espionnage technique");
            c1m2a0.AjouteInformateur(c1m2a0i3);
            c1.AjouteAgentMission("Clématite", c1m2a0);
            c1.AjouteAgentMission("Clématite", c1m0a1);
            Agent c1m2a1 = new Agent(new Identité("Lincoln", "Graham"), 31);
            Informateur c1m2a1i0 = new Informateur(new Identité("Emily", "May"), 24);
            c1m2a1i0.AjouteDomaine("blanchiment d'argent");
            c1m2a1i0.AjouteDomaine("racket");
            c1m2a1.AjouteInformateur(c1m2a1i0);
            Informateur c1m2a1i1 = new Informateur(new Identité("Layla",
            "Washington"), 34);
            c1m2a1i1.AjouteDomaine("drogue");
            c1m2a1i1.AjouteDomaine("drogue");
            c1m2a1i1.AjouteDomaine("pègre");
            c1m2a1.AjouteInformateur(c1m2a1i1);
            Informateur c1m2a1i2 = new Informateur(new Identité("Mason", "Harrison"),
            37);
            c1m2a1i2.AjouteDomaine("pègre");
            c1m2a1i2.AjouteDomaine("mafia");
            c1m2a1.AjouteInformateur(c1m2a1i2);
            Informateur c1m2a1i3 = new Informateur(new Identité("Dylan", "Blake"),
            33);
            c1m2a1i3.AjouteDomaine("vente d'armes");
            c1m2a1i3.AjouteDomaine("blanchiment d'argent");
            c1m2a1i3.AjouteDomaine("cambriolages");
            c1m2a1.AjouteInformateur(c1m2a1i3);
            Informateur c1m2a1i4 = new Informateur(new Identité("Adeline", "Ann"),
            35);
            c1m2a1i4.AjouteDomaine("espionnage technique");
            c1m2a1i4.AjouteDomaine("drogue");
            c1m2a1.AjouteInformateur(c1m2a1i4);
            Informateur c1m2a1i5 = new Informateur(new Identité("Michael", "Miles"),
            34);
            c1m2a1i5.AjouteDomaine("pègre");
            c1m2a1i5.AjouteDomaine("cambriolages");
            c1m2a1.AjouteInformateur(c1m2a1i5);
            c1.AjouteAgentMission("Clématite", c1m2a1);
            Agent c1m3a0 = new Agent(new Identité("Addison", "Reynolds"), 43);
            Informateur c1m3a0i0 = new Informateur(new Identité("Charlotte", "Hunt"),
            40);
            c1m3a0i0.AjouteDomaine("drogue");
            c1m3a0.AjouteInformateur(c1m3a0i0);
            Informateur c1m3a0i1 = new Informateur(new Identité("Aiden", "Bryan"),
            20);
            c1m3a0i1.AjouteDomaine("drogue");
            c1m3a0i1.AjouteDomaine("racket");
            c1m3a0i1.AjouteDomaine("mafia");
            c1m3a0.AjouteInformateur(c1m3a0i1);
            Informateur c1m3a0i2 = new Informateur(new Identité("Ella", "Fletcher"),
            29);
            c1m3a0i2.AjouteDomaine("cambriolages");
            c1m3a0.AjouteInformateur(c1m3a0i2);
            Informateur c1m3a0i3 = new Informateur(new Identité("Hailey",
            "Fletcher"), 31);
            c1m3a0i3.AjouteDomaine("pègre");
            c1m3a0i3.AjouteDomaine("blanchiment d'argent");
            c1m3a0.AjouteInformateur(c1m3a0i3);
            Informateur c1m3a0i4 = new Informateur(new Identité("Scarlett", "Lee"),
            37);
            c1m3a0i4.AjouteDomaine("cambriolages");
            c1m3a0.AjouteInformateur(c1m3a0i4);
            Informateur c1m3a0i5 = new Informateur(new Identité("Emily", "Roberts"),
            40);
            c1m3a0i5.AjouteDomaine("contrebande");
            c1m3a0i5.AjouteDomaine("blanchiment d'argent");
            c1m3a0.AjouteInformateur(c1m3a0i5);
            c1.AjouteAgentMission("Lys", c1m3a0);
            Agent c1m3a1 = new Agent(new Identité("Hailey", "Graham"), 20);
            Informateur c1m3a1i0 = new Informateur(new Identité("Jayce", "Nichols"),
            30);
            c1m3a1i0.AjouteDomaine("espionnage technique");
            c1m3a1.AjouteInformateur(c1m3a1i0);
            Informateur c1m3a1i1 = new Informateur(new Identité("Oliver", "Wood"),
            20);
            c1m3a1i1.AjouteDomaine("contrebande");
            c1m3a1i1.AjouteDomaine("crime organisé");
            c1m3a1.AjouteInformateur(c1m3a1i1);
            c1.AjouteAgentMission("Lys", c1m3a1);
            Agent c1m3a2 = new Agent(new Identité("Hailey", "Hill"), 39);
            Informateur c1m3a2i0 = new Informateur(new Identité("Mackenzie", "Kerr"),
            33);
            c1m3a2i0.AjouteDomaine("crime organisé");
            c1m3a2.AjouteInformateur(c1m3a2i0);
            Informateur c1m3a2i1 = new Informateur(new Identité("Addison", "Knight"),
            25);
            c1m3a2i1.AjouteDomaine("mafia");
            c1m3a2i1.AjouteDomaine("blanchiment d'argent");
            c1m3a2i1.AjouteDomaine("pègre");
            c1m3a2.AjouteInformateur(c1m3a2i1);
            Informateur c1m3a2i2 = new Informateur(new Identité("Nicholas",
            "Hunter"), 30);
            c1m3a2i2.AjouteDomaine("mafia");
            c1m3a2.AjouteInformateur(c1m3a2i2);
            Informateur c1m3a2i3 = new Informateur(new Identité("Nicholas", "Davis"),
            28);
            c1m3a2i3.AjouteDomaine("blanchiment d'argent");
            c1m3a2.AjouteInformateur(c1m3a2i3);
            Informateur c1m3a2i4 = new Informateur(new Identité("Victoria", "Kerr"),
            44);
            c1m3a2i4.AjouteDomaine("mafia");
            c1m3a2.AjouteInformateur(c1m3a2i4);
            Informateur c1m3a2i5 = new Informateur(new Identité("Landon", "Ellis"),
            22);
            c1m3a2i5.AjouteDomaine("mafia");
            c1m3a2i5.AjouteDomaine("pègre");
            c1m3a2i5.AjouteDomaine("racket");
            c1m3a2.AjouteInformateur(c1m3a2i5);
            c1.AjouteAgentMission("Lys", c1m3a2);
            Agent c1m4a0 = new Agent(new Identité("Dylan", "Saunders"), 37);
            Informateur c1m4a0i0 = new Informateur(new Identité("Jayden", "Ellis"),
            46);
            c1m4a0i0.AjouteDomaine("racket");
            c1m4a0i0.AjouteDomaine("blanchiment d'argent");
            c1m4a0.AjouteInformateur(c1m4a0i0);
            Informateur c1m4a0i1 = new Informateur(new Identité("Ethan", "Wheeler"),
            45);
            c1m4a0i1.AjouteDomaine("drogue");
            c1m4a0i1.AjouteDomaine("espionnage technique");
            c1m4a0i1.AjouteDomaine("vente d'armes");
            c1m4a0.AjouteInformateur(c1m4a0i1);
            c1.AjouteAgentMission("Joubarde", c1m4a0);
            Agent c1m4a1 = new Agent(new Identité("Peyton", "Walker"), 24);
            Informateur c1m4a1i0 = new Informateur(new Identité("Mackenzie",
            "Coleman"), 40);
            c1m4a1i0.AjouteDomaine("cambriolages");
            c1m4a1i0.AjouteDomaine("vente d'armes");
            c1m4a1i0.AjouteDomaine("racket");
            c1m4a1.AjouteInformateur(c1m4a1i0);
            Informateur c1m4a1i1 = new Informateur(new Identité("Nathan", "Dunn"),
            47);
            c1m4a1i1.AjouteDomaine("blanchiment d'argent");
            c1m4a1i1.AjouteDomaine("vente d'armes");
            c1m4a1.AjouteInformateur(c1m4a1i1);
            Informateur c1m4a1i2 = new Informateur(new Identité("Camilla", "Adams"),
            38);
            c1m4a1i2.AjouteDomaine("mafia");
            c1m4a1.AjouteInformateur(c1m4a1i2);
            c1.AjouteAgentMission("Joubarde", c1m4a1);
            c1.AjouteAgentMission("Joubarde", c1m0a1);
            Agent c1m4a2 = new Agent(new Identité("Mason", "Brown"), 46);
            Informateur c1m4a2i0 = new Informateur(new Identité("Mackenzie",
            "Henry"), 24);
            c1m4a2i0.AjouteDomaine("vente d'armes");
            c1m4a2i0.AjouteDomaine("cambriolages");
            c1m4a2.AjouteInformateur(c1m4a2i0);
            Informateur c1m4a2i1 = new Informateur(new Identité("Lucas", "Barrett"),
            30);
            c1m4a2i1.AjouteDomaine("espionnage technique");
            c1m4a2.AjouteInformateur(c1m4a2i1);
            Informateur c1m4a2i2 = new Informateur(new Identité("Caleb", "Sanders"),
            27);
            c1m4a2i2.AjouteDomaine("cambriolages");
            c1m4a2.AjouteInformateur(c1m4a2i2);
            c1.AjouteAgentMission("Joubarde", c1m4a2);
            
            Console.Write(c1);


        }
    }
}