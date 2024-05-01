namespace Psychosis.Characters
{
    public class Robert : Character
    {
        public Robert()
        {
            // Initialize character data
            Name = "Robert";
            Information = new Dictionary<string, object>
            {
                { "gender", "Male" },
                { "birthdate", DateTime.Now },
                { "size", 1 * 3 * 1 },
                { "pigment", new Dictionary<string, int> { { "red", 0 }, { "green", 255 }, { "blue", 0 } } },
                { "odor", "100001" }
            };
            Attributes = new Dictionary<string, int>
            {
                { "Strength/Power", 1 },
                { "Endurance/Stamina", 1 },
                { "Speed/Agility", 1 },
                { "Perception/Recognition", 1 },
                { "Intelligence/Logistics", 1 },
                { "Knowledge/Memory", 1 },
                { "Experience/Wisdom", 1 },
                { "Will/Determination", 1 },
                { "Patience/Poise", 1 },
                { "Flexibility/Elasticity", 1 },
                { "Balance/Dexterity", 1 }
            };
            SkillTree = new Dictionary<string, int> { { "Observation", 1 } };
            Traits = new Dictionary<string, Dictionary<string, int>>
            {
                { "physical", new Dictionary<string, int> { { "strength", 0 }, { "speed", 0 }, { "aggression", 0 }, { "health", 0 }, { "appeal", 0 } } },
                { "social", new Dictionary<string, int> { { "humility", 0 }, { "temperament", 0 }, { "generosity", 0 }, { "loyalty", 0 }, { "honesty", 0 } } },
                { "Emotional", new Dictionary<string, int> { { "Spontaneity", 0 }, { "Mannerism", 0 }, { "Rage", 0 } } },
                { "Behavioral", new Dictionary<string, int> { { "Curiosity", 0 }, { "Dependency", 0 }, { "Confidence", 0 }, { "Ambition", 0 } } },
                { "Intellectual", new Dictionary<string, int> { { "Creativity", 0 }, { "Concentration", 0 }, { "Intelligence", 0 } } }
            };
            Occupation = "Adventurer";
            Inventory = new Dictionary<string, object>
            {
                { "gold", 0 },
                { "silver", 0 },
                { "equipped", new Dictionary<string, string>
                    {
                        { "Head", "" },
                        { "Shoulders", "" },
                        { "Chest", "Rugged Linen Shirt (.5lbs){Durability: 50%}" },
                        { "Arms", "" },
                        { "Waist", "Rugged Cotton Belt (.5lbs){Durability: 50%}" },
                        { "Legs", "Rugged Linen Pants (.5lbs){Durability: 50%}" },
                        { "Feet", "Rugged Rubber Boots (.5lbs){Durability: 50%}" },
                        { "Right Hand", "" },
                        { "Left Hand", "" }
                    }
                },
                { "bag", new Dictionary<string, string> { { "Item(Weight)", "" } } }
            };
            Quests = new Dictionary<string, string> { { "Maia", "Speak with the Barkeep." } };
            Reputation = new Dictionary<string, int> { { "fame", 100 }, { "notoriety", 0 } };
            Relationships = new Dictionary<string, List<string>>
            {
                { "allies", new List<string> { "Alek" } },
                { "enemies", new List<string>() },
                { "Friends", new List<string> { "Alek" } },
                { "Acquaintances", new List<string>() },
                { "Rivals", new List<string>() }
            };
            Relationships["loyalty"] = new List<string> { "Alek" };
            Relationships["fear"] = new List<string>();
            Relationships["respect"] = new List<string>();
            Relationships["morality"] = new List<string>();
        }
    }
}