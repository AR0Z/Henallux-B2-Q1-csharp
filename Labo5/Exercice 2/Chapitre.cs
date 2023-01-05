using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labo5.Exercice_2
{
    public class Chapitre
    {
        private string ville;
        private LinkedList<Agent> agents;
        private Dictionary<string, string> safehouses;
        private Dictionary<string, HashSet<Agent>> missions;

        public Chapitre(string ville)
        {
            this.ville = ville;
            agents = new LinkedList<Agent>();
            safehouses = new Dictionary<string, string>();
            missions = new Dictionary<string, HashSet<Agent>>();
        }
        
        // Gestion Agent
     
        public void AjouteAgent(Agent agent)
        {
            if (!agents.Contains(agent))
            {
                agents.AddLast(agent);
            }
        }

        public Agent DernierAgentEnDate
        {
            get
            {
                return agents.Last.Value;
            }

            set
            {
                AjouteAgent(value);
            }
        }

        public void SupprimeAgent(Agent agent)
        {
            if (agents.Contains(agent))
            {
                agents.Remove(agent);
            }
        }

        public HashSet<Agent> AgentsSelonID(Identité identité)
        {
            HashSet<Agent> agents = new HashSet<Agent>();

            foreach (Agent agent in this.agents)
            {
                bool nomOk = (identité.Nom == null || identité.Nom == agent.Identité.Nom);
                bool prenomOk = (identité.Prénom == null || identité.Prénom == agent.Identité.Prénom);

                if (nomOk && prenomOk)
                    agents.Add(agent);
            }
                
            return agents;
        }

        public void AfficheAgentsSelonID(Identité identité)
        {
            HashSet<Agent> agents = AgentsSelonID(identité);

            foreach (Agent agent in agents)
            {
                Console.WriteLine(agent);
            }
        }
        
        // Gestion safehouse

        public void AjouteSafehouse(string code, string adresse)
        {
            if (!safehouses.ContainsKey(code))
            {
                safehouses.Add(code, adresse);
            }
        }

        public string AdresseSafehouse(string code)
        {
            string value;
            if (safehouses.TryGetValue(code, out value))
            {
                return value;
            }
            return "Code inconnu";
        }

        public void AfficheCodesSafehouses()
        {
            foreach (var safehouse in safehouses)
            {
                Console.Write(safehouse.Key);
            }
        }
        
        // Gestion missions

        public void AjouteMission(string code)
        {
            if (!missions.ContainsKey(code))
            {
                missions.Add(code, new HashSet<Agent>());
            }
        }

        public void AjouteAgentMission(string code, Agent agent)
        {
            if (!missions.ContainsKey(code))
            {
                missions.Add(code, new HashSet<Agent>());
            }

            if (!missions[code].Contains(agent))
            {
                missions[code].Add(agent); 
            }
        }

        public void AjouteMission(string code, params Agent[] agentn)
        {
            foreach (Agent agent in agentn)
            {
                AjouteAgentMission(code, agent);
            }
        }

        public void AfficheMissions(Agent agent)
        {
            foreach (var mission in missions)
            {
                if (mission.Value.Contains(agent))
                {
                    Console.Write(mission.Key);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder($"Informations sur le chapitre de {ville}{Environment.NewLine}");

            toString.AppendLine($"AGENTS :{Environment.NewLine}");
            foreach (Agent agent in agents)
            {
                toString.AppendLine($"{agent}{Environment.NewLine}");
            }
            
            toString.AppendLine($"SAFEHOUSES :{Environment.NewLine}");

            foreach (var safehouse in safehouses)
            {
                toString.Append($"{safehouse.Key} : {safehouse.Value}{Environment.NewLine}");
            }
            
            toString.Append(Environment.NewLine);
            
            foreach (var mission in missions)
            {
                toString.Append($"MISSION {mission.Key} ({mission.Value.Count} agents){Environment.NewLine}{Environment.NewLine}");

                foreach (Agent agent in mission.Value)
                {
                    toString.Append($"{agent}{Environment.NewLine}{Environment.NewLine}");
                }
            }
            
            return toString.ToString();
        }
    }
}