using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psychosis.Characters.Characters
{
    public class Stats
    {
        public string Occupation { get; set; } = "Vagrant"; // Default occupation
        public int Health { get; set; } = 100; // Default health value
        public int Energy { get; set; } = 100; // Default energy value
        public int Hunger { get; set; } = 0; // Default hunger value
        public int Thirst { get; set; } = 0; // Default thirst value
        public int Strength { get; set; } = 5; // Default strength value
        public int Endurance { get; set; } = 5; // Default endurance value
        public int Speed { get; set; } = 5; // Default speed value
        public int Perception { get; set; } = 5;
        public int Intelligence { get; set; } = 5;
        public int Knowledge { get; set; } = 5;
        public int Experience { get; set; } = 0;
        public int Will { get; set; } = 5;
        public int Patience { get; set; } = 5;
        public int Flexibility { get; set; } = 5;
        public int Balance { get; set; } = 5;
        public int Charisma { get; set; } = 5;
    }
}
