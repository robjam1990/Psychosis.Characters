using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psychosis.Characters.Characters.Occupations
{
    internal class Occupation
    {

        public class OccupationList
        {
            public Dictionary<string, List<string>> Occupations { get; set; }

            public OccupationList()
            {
                Occupations = new Dictionary<string, List<string>>
        {
            { "Royalty", new List<string> { "King", "Queen", "Lord", "Lady" } },
            { "Military", new List<string> { "Guard", "Soldier", "Captain", "Commander", "General" } },
            { "Civilian", new List<string> { "Bard", "Alchemist", "Tanner", "Healer", "Farmer", "Blacksmith", "Barkeep", "Barmaid", "ShopKeep", "Apprentice", "Assistant", "Fletcher", "Butcher", "Weaver", "Potter" } },
            { "Labour", new List<string> { "Miner", "Hunter", "Athlete", "Scavenger", "Servant" } },
            { "Criminal", new List<string> { "Thief", "Murderer", "Assassin", "Pirate", "Bandit" } },
            { "Traversal", new List<string> { "Slave", "Settler", "Adventurer", "Explorer" } },
            { "Dangerous", new List<string> { "Mercenary" } },
            { "School", new List<string> { "Doctor", "Teacher", "Scholar", "Genius" } },
            { "Specialist", new List<string> { "Researcher", "Engineer", "Inventor", "Architect", "Plumber", "Pilot" } },
            { "Other", new List<string> { "Idiot", "Jester", "Judge", "Executioner", "Vagrant", "Priest" } }
        };
            }
        }
    }
}
