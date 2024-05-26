            {
                Description = description // Set the character's description
            }; // Create a new character with default color
            Alek.Draw(); // Draw the character
            WriteLine("\nCharacter created."); // Write a message
            TextAnimation.WaitForKey(); // Wait for a key press
        }

        public void AdjustOxygen()
        {
            while (UnderWater)
            {
                Oxygen--;
                WriteLine($"{Species} {Name} oxygen level adjusted to {Oxygen}.");
            }
        }
    }
}
using System;
using System.Collections.Generic;

class Character
{
    public Player Name { get; set; } = Alek!;
    public Dictionary<string, dynamic>? Information { get; set; }
    public Dictionary<string, int>? Attributes { get; set; }
    public Dictionary<string, int>? SkillTree { get; set; }
    public Dictionary<string, Dictionary<string, int>>? Traits { get; set; }
    public (string, string)? Occupation { get; set; }
    public Dictionary<string, dynamic>? Inventory { get; set; }
    public Dictionary<string, string>? Quests { get; set; }
    public Dictionary<string, dynamic>? Reputation { get; set; }
    public Dictionary<string, dynamic>? Relationships { get; set; }
    public static Player? Alek { get; private set; }

    public Character(string name, string gender, string odor, string occupation)
    {
        string? userInput = GetUserInput();
        int? inputLength = userInput?.Length;
        if (inputLength == null)
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        Information = new Dictionary<string, dynamic>
        {
            { "gender", "Male" },
            { "birthdate", DateTime.Now },
            { "getAge", (Func<int>)(() =>
                {
                    if (Information!.TryGetValue("birthdate", out dynamic? valueBirthDate) && valueBirthDate != null)
                    {
                        if (valueBirthDate is DateTime birthDate)
                        {
                            TimeSpan age = DateTime.Now - birthDate;
                            return (int)(age.TotalDays / 365);
                        }
                        else
                        {
                            Console.WriteLine("Error: Birth date value is not a DateTime.");
                            return 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Birth date value is null.");
                        return 0;
                    }
                })
            },
            { "size", 1 * 4 * 1 },
            { "pigment", new Dictionary<string, int> { { "red", 255 }, { "green", 0 }, { "blue", 0 } } },
            { "odor", "101101" }
        };
        Attributes = new Dictionary<string, int>
        {
            { "Strength/Power", 3 },
            { "Endurance/Stamina", 3 },
            { "Speed/Agility", 1 },
            { "Perception/Recognition", 2 },
            { "Intelligence/Logistics", 1 },
            { "Knowledge/Memory", 2 },
            { "Experience/Wisdom", 1 },
            { "Will/Determination", 1 },
            { "Patience/Poise", 1 },
            { "Flexibility/Elasticity", 1 },
            { "Balance/Dexterity", 2 }
        };
        SkillTree = new Dictionary<string, int>
        {
            { "Observation", 1 },
            { "Identification", 1 }
        };
        Traits = new Dictionary<string, Dictionary<string, int>>
        {
            { "physical", new Dictionary<string, int> { { "strength", 0 }, { "speed", 0 }, { "aggression", 0 }, { "health", 0 }, { "appeal", 0 } } },
            { "social", new Dictionary<string, int> { { "humility", 0 }, { "temperament", 0 }, { "generosity", 0 }, { "loyalty", 0 }, { "honesty", 0 } } },
            { "Emotional", new Dictionary<string, int> { { "Spontaneity", 0 }, { "Mannerism", 0 }, { "Rage", 0 } } },
            { "Behavioral", new Dictionary<string, int> { { "Curiosity", 0 }, { "Dependency", 0 }, { "Confidence", 0 }, { "Ambition", 0 } } },
            { "Intellectual", new Dictionary<string, int> { { "Creativity", 0 }, { "Concentration", 0 }, { "Intelligence", 0 } } }
        };
        Occupation = ("Adventurer", "Miner");
        Inventory = new Dictionary<string, dynamic>
        {
            { "gold", 0 },
            { "silver", 0 },
            { "equipped", new Dictionary<string, string>
                {
                    { "Head", "" },
                    { "Shoulders", "Goat Hide Pauldrons (4lbs)" },
                    { "Chest", "Rugged Linen Shirt (.5lbs)" },
                    { "Arms", "" },
                    { "Waist", "Rugged Cotton Belt (.5lbs)" },
                    { "Legs", "Rugged Linen Pants (.5lbs)" },
                    { "Feet", "Rugged Rubber Boots (.5lbs)" },
                    { "Right Hand", "Heavy Pickaxe (5lbs)" },
                    { "Left Hand", "Knife (.5lbs)" }
                }
            },
            { "bag", new Dictionary<string, string> { { "Item(Weight)", "Potatoes (2.5lbs), Iron plated Iron Chestpiece (9lbs), Raw Iron (1lbs), Damaged Iron (2.5lbs), Damaged Stick (.5lbs), Bedroll (2lbs), Raw Goat Meat (15lbs), Blings Things (2lbs)" } } }
        };
        Quests = new Dictionary<string, string>
        {
            { "Aithaluwa", "Make a chestpiece of any type" },
            { "Blacksmith Assisstant", "Mine Iron" },
            { "Brans Wife", "Speak with Bran (Completed)" },
            { "Bran", "Help in the field (Completed)" },
            { "Ark", "Speak with Ajax (Completed)" },
            { "Ajax", "Bring 5 Iron weapons of Good quality or higher" },
            { "Blacksmith Apprentice", "Discover Steel Mine" },
            { "Blacksmith", "Mine Titanium or Aluminum" },
            { "Bling", "Deliver Blings Things to the Good Son" }
        };
        Reputation = new Dictionary<string, dynamic> { { "fame", 0 }, { "notoriety", 0 } };
        Relationships = new Dictionary<string, dynamic>
        {
            { "allies", new List<string> { "Robert" } },
            { "enemies", new List<string>() },
            { "loyalty", 85 },
            { "fear", 35 },
            { "respect", 95 },
            { "morality", 0.63 },
            { "Friends", new List<string> { "Robert" } },
            { "Acquaintances", new List<string> { "Weaver", "Bran", "Miner" } },
            { "Rivals", new List<string>() }
        };
    }

    private string? GetUserInput()
    {
        Console.WriteLine("Enter your birthdate (MM/DD/YYYY): ");
        string? input = Console.ReadLine();
        return input;
    }
}

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public float Health { get; set; }
    public bool IsAlive { get; set; }

    public Player(string name, int level, float health, bool isAlive)
    {
        Name = name;
        Level = level;
        Health = health;
        IsAlive = isAlive;
    }
}

class DisplayCharacterSheet
{
    private static void DisplayCharacter(Character character)
    {
        if (character == null)
        {
            Console.WriteLine("Invalid character data.");
            return;
        }

        Console.WriteLine("Character Name: " + character.Name);
        // Display information section
        Console.WriteLine("\nInformation:");
        Console.WriteLine("- Gender: " + character.Information!["gender"]);
        Console.WriteLine("- Age: " + character.Information["getAge"]());
        Console.WriteLine("- Size: " + character.Information["size"]);
        Console.WriteLine("- Pigment: R:" + character.Information["pigment"]["red"] +
            ", G:" + character.Information["pigment"]["green"] +
            ", B:" + character.Information["pigment"]["blue"]);
        Console.WriteLine("- Odor: " + character.Information["odor"]);

        // Display attributes
        Console.WriteLine("\nAttributes:");
        foreach (KeyValuePair<string, int> attribute in character.Attributes)
        {
            Console.WriteLine("- " + attribute.Key + ": " + attribute.Value);
        }

        // Display skill tree
        if (character.SkillTree != null)
        {
            Console.WriteLine("\nSkill Tree:");
            foreach (KeyValuePair<string, int> skill in character.SkillTree)
            {
                Console.WriteLine("- " + skill.Key + ": Level " + skill.Value);
            }
        }

        // Display inventory
        Console.WriteLine("\nInventory:");
        foreach (KeyValuePair<string, dynamic> item in character.Inventory!)
        {
            if (item.Value is Dictionary<string, string>)
            {
                Console.WriteLine("- " + item.Key + ": ");
                foreach (KeyValuePair<string, string> equippedItem in (Dictionary<string, string>)item.Value)
                {
                    Console.WriteLine("  - " + equippedItem.Key + ": " + equippedItem.Value);
                }
            }
            else
            {
                Console.WriteLine("- " + item.Key + ": " + item.Value);
            }
        }

        // Display quests
        Console.WriteLine("\nQuests:");
        foreach (KeyValuePair<string, string> quest in character.Quests)
        {
            Console.WriteLine("- " + quest.Key + ": " + quest.Value);
        }

        // Display relations
        Console.WriteLine("\nRelations:");
        foreach (KeyValuePair<string, dynamic> relation in character.Relationships!)
        {
            Console.WriteLine(relation.Key + ":");
            if (relation.Value is List<string>)
            {
                foreach (string person in (List<string>)relation.Value)
                {
                    Console.WriteLine("- " + person);
                }
            }
            else
            {
                Console.WriteLine("- " + relation.Value);
            }
        }
    }
}


