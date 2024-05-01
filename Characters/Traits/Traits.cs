using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psychosis.Characters.Characters
{

    public class Traits
    {
        public Dictionary<string, Dictionary<string, int>> TraitsData { get; set; }

        public Traits()
        {
            TraitsData = new Dictionary<string, Dictionary<string, int>>
        {
            { "Physical", new Dictionary<string, int> { { "Strength", 0 }, { "Speed", 0 }, { "Aggression", 0 }, { "Health", 0 }, { "Appeal", 0 } } },
            { "Social", new Dictionary<string, int> { { "Humility", 0 }, { "Temperament", 0 }, { "Generosity", 0 }, { "Loyalty", 0 }, { "Honesty", 0 } } },
            { "Emotional", new Dictionary<string, int> { { "Spontaneity", 0 }, { "Mannerism", 0 }, { "Rage", 0 } } },
            { "Behavioral", new Dictionary<string, int> { { "Curiosity", 0 }, { "Dependency", 0 }, { "Confidence", 0 }, { "Ambition", 0 } } },
            { "Intellectual", new Dictionary<string, int> { { "Creativity", 0 }, { "Concentration", 0 }, { "Intelligence", 0 } } }
        };
        }
    }
}
