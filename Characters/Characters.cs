
}
    }
        Party = new List<Character>();
Attributes = attributes;
Gold = gold;
{
    public Player(int gold, Dictionary<string, int> attributes)

    public List<Character> Party { get; }
public Dictionary<string, int> Attributes { get; }
public int Gold { get; set; }
{
public class Player

}
    }
        return player.Attributes.ContainsKey(Attribute) && player.Attributes[Attribute] >= Value;
// Check if player's attribute meets requirement
{
    public bool Check(Player player)

    }
this.v2 = v2;
this.v1 = v1;
{
    public AttributeRequirement(string attribute, int value, string v1, int v2) : this(attribute, value)

    }
Value = value;
Attribute = attribute;
{
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public AttributeRequirement(string attribute, int value)
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public int Value { get; }
public string Attribute { get; }

private int v2;
private string v1;
{
public class AttributeRequirement

}
    }
        else Console.WriteLine("Unknown Task.");
        }
            Attributes["Thirst"] += 30;
Attributes["Hunger"] += 40;
Attributes["Energy"] -= 40;
{
        else if (task == "fighting")
        }
Attributes["Thirst"] += 20;
Attributes["Hunger"] += 30;
Attributes["Energy"] -= 30;
{
        else if (task == "crafting")
        }
Attributes["Thirst"] += 10;
Attributes["Hunger"] += 20;
Attributes["Energy"] -= 20;
{
        else if (task == "gathering resources")
        }
Attributes["Hunger"] += 10;
Attributes["Energy"] -= 10;
{
        else if (task == "exploring")
        }
            }
                Attributes[attribute.Key] = Math.Min(100, attribute.Value + 10);
{
    foreach (var attribute in Attributes)
    {
        if (task == "resting")
            Console.WriteLine($"{Name} is {task}.");
        {
            internal void DoTask(string task)
    
    }
        return true;
    }
}
return false;
{
    if (!requirement.Check(player))
    {
        foreach (var requirement in Requirements)
        // Check if player meets all requirements for recruitment
        {
            public bool CheckRequirements(Player player)

    }
        Console.WriteLine($"{Name} has been recruited to your party.");

        Recruited = true;
        // Mark character as recruited

        player.Party.Add(this);
        // Add character to player's party

        player.Gold -= Price;
        // Deduct gold from player's inventory

    }
    return;
    Console.WriteLine($"Insufficient gold to recruit {Name}.");
    {
        if (player.Gold < Price)
        // Check if player has enough gold

        }
    return;
    Console.WriteLine($"{Name} cannot be recruited at this time.");
    {
        if (!CheckRequirements(player))
        // Check if player meets recruitment requirements

        }
    return;
    Console.WriteLine($"{Name} has already been recruited.");
    {
        if (Recruited)
        // Check if the character has already been recruited
        {
            public void Recruit(Player player)

    }
        Recruited = false;
        Requirements = requirements;
        Price = price;
        Attributes = attributes;
        Role = role;
        Name = name;
        {
            public Character(string name, string role, Dictionary<string, int> attributes, int price, List<AttributeRequirement> requirements)

    public bool Recruited { get; private set; }
public List<AttributeRequirement> Requirements { get; }
public int Price { get; }
public Dictionary<string, int> Attributes { get; }
public string Role { get; }
public string Name { get; }
{
public class Character

using System.Collections.Generic;
using System;using System;
using System.Collections.Generic;
using static System.Console;

public class Location
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Location(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int Health { get; set; } // Added Health property
    public int Score { get; set; } // Added Score property

    public Dictionary<string, int> Skills { get; set; }
    public Dictionary<string, int> Resources { get; set; }
    public List<Quest> ActiveQuests { get; set; }
    public List<Enemy> Enemies { get; set; }
    public List<Weapon> Weapons { get; set; }
    public List<InventoryItem> InventoryItems { get; set; }
    public Location Location { get; set; } // Declare a Location property

    // Constructor
    public Character(string name)
    {
        Name = name;
        Level = 1;
        Experience = 0;
        Health = 100; // Default health value
        Score = 0;
        Skills = new Dictionary<string, int>();
        Resources = new Dictionary<string, int>();
        ActiveQuests = new List<Quest>();
        Enemies = new List<Enemy>();
        Weapons = new List<Weapon>();
        InventoryItems = new List<InventoryItem>();
        Location = new Location(0, 0, 0); // Initialize the Location property with default values

    }

    public void AddExperience(int amount)
    {
        Experience += amount;
        if (Experience >= Level * 100)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level++;
        Experience = 0;
        WriteLine($"Congratulations, {Name}! You are now level {Level}!");
    }

    public void Move(int x, int y, int z)
    {
        Location.X += x;
        Location.Y += y;
        Location.Z += z;
    }

    public void AddResource(string resource, int quantity)
    {
        if (Resources.ContainsKey(resource))
        {
            Resources[resource] += quantity;
        }
        else
        {
            Resources.Add(resource, quantity);
        }
    }

    public void RemoveResource(string resource, int quantity)
    {
        if (Resources.ContainsKey(resource))
        {
            Resources[resource] -= quantity;
            if (Resources[resource] <= 0)
            {
                Resources.Remove(resource);
            }
        }
    }

    public void IncreaseSkill(string skill, int amount)
    {
        if (Skills.ContainsKey(skill))
        {
            Skills[skill] += amount;
        }
        else
        {
            Skills.Add(skill, amount);
        }
    }

    public void DecreaseSkill(string skill, int amount)
    {
        if (Skills.ContainsKey(skill))
        {
            Skills[skill] -= amount;
            if (Skills[skill] <= 0)
            {
                Skills.Remove(skill);
            }
        }
    }

    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; } // Define a Damage property

        // Constructor
        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }

    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }

        // Constructor
        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // Define a TakeDamage method
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                WriteLine($"Enemy {Name} has been defeated!");
            }
            else
            {
                WriteLine($"Enemy {Name} took {damage} damage. Remaining health: {Health}");
            }
        }
    }

    public void Attack(Enemy enemy, Weapon weapon)
    {
        int damage = weapon.Damage;
        enemy.TakeDamage(damage);
    }

    public class InventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public InventoryItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }

    public void UseItem(InventoryItem item)
    {
        // Add item usage logic here
        if (item.Name == "Health Potion")
        {
            // Increase player's health by a certain amount
            Health += 50;
            WriteLine("Player's health increased by 50.");
        }
        else if (item.Name == "Attack Boost")
        {
            // Increase player's attack damage by a certain amount
            foreach (Weapon weapon in Weapons)
            {
                weapon.Damage += 10;
            }
            WriteLine("Player's attack damage increased by 10.");
        }
        else
        {
            WriteLine("Item cannot be used.");
        }
    }

    public void StartQuest(Quest quest)
    {
        ActiveQuests.Add(quest);
    }

    public void AbandonQuest(Quest quest)
    {
        ActiveQuests.Remove(quest);
    }

    public class Quest
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        // Constructor
        public Quest(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        // Define a CompleteQuest method
        public void CompleteQuest()
        {
            IsCompleted = true;
            WriteLine($"Quest '{Name}' has been completed!");
        }
    }


    public void RemoveQuest(Quest quest)
    {
        ActiveQuests.Remove(quest);
    }

    public void AddEnemy(Enemy enemy)
    {
        Enemies.Add(enemy);
    }

    public void RemoveEnemy(Enemy enemy)
    {
        Enemies.Remove(enemy);
    }

    public void AddWeapon(Weapon weapon)
    {
        Weapons.Add(weapon);
    }

    public void RemoveWeapon(Weapon weapon)
    {
        Weapons.Remove(weapon);
    }

    public void AddInventoryItem(InventoryItem item)
    {
        InventoryItems.Add(item);
    }

    public void RemoveInventoryItem(InventoryItem item)
    {
        InventoryItems.Remove(item);
    }

    public void UseSkill(string skill)
    {
        if (Skills.ContainsKey(skill))
        {
            // Implement logic to use the skill
            WriteLine($"Using skill: {skill}");
        }
        else
        {
            WriteLine($"Skill not found: {skill}");
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            WriteLine("Player has been defeated!");
        }
    }

    public void DecreaseScore(int points)
    {
        Score -= points;
    }

    public void IncreaseScore(int points)
    {
        Score += points;
    }
}


using Psychosis.Characters.Characters.Occupations;
using System.Xml.Linq;
using static System.Console;
using static Psychosis.TextAnimation;

namespace Psychosis
{
    // Define the characters data
    public class Character
    {
        public string Name { get; set; } = "name";
        public string? Residence { get; set; } = null;
        public string Occupation { get; set; } = "Vagrant";
        public int ItemAmount { get; set; } = 0;
        public int Silver { get; set; } = 0;
        public int Health { get; set; } = 100;
        public Dictionary<string, object> Limbs { get; set; } = new Dictionary<string, object>()
    {
        {"head", true},
        {"arms", new Dictionary<string, bool>() { {"left", true}, {"right", true} } },
        {"legs", new Dictionary<string, bool>() { {"left", true}, {"right", true} } }
    };
        public Dictionary<string, int> Skills { get; set; } = new Dictionary<string, int>()
    {
        {"combat", new Random().Next(1, 11)},
        {"crafting", new Random().Next(1, 11)},
        {"diplomacy", new Random().Next(1, 11)}
    };
        public double Morality { get; set; } = new Random().NextDouble();
        public string Location { get; set; } = "Taverne(Main Hall)";
        public Dictionary<string, object> Inventory { get; set; } = new Dictionary<string, object>();
        public object? Faction { get; set; } = null;

        internal void Deserialize(string data)
        {
            File.ReadAllText(data);
        }

        internal string Serialize()
        {
            return File.ReadAllText(Location);
        }
    }

    public class Initialize
    {
        private static List<Character> charactersData = new List<Character>();
        private object? output;

        public object? Name { get; private set; }
        public object? Item { get; private set; }
        public object? ItemAmount { get; private set; }
        public object? Silver { get; private set; }
        public object? Age { get; private set; }

        // Function to initialize characters
        private static void InitializeCharacters()
        {
            charactersData.AddRange(new Character[]
            {
            new Character { Name = "Opus", Occupation = "Oracle", Residence = "Nexus Temple" },
new Character { Name = "Apus", Occupation = "Queen of Bractalia", Residence = "Bractal Castle" },
new Character { Name = "Maia", Occupation = "Greeter", Residence = "Ye Olde Taverne" },
new Character { Name = "Arkantos", Occupation = "Mercenary", Residence = "Ye Olde Taverne" },
new Character { Name = "Bling", Occupation = "Shopkeeper", Residence = "Weavery" },
new Character { Name = "Bran", Occupation = "Farmer", Residence = "Brans Farmhouse" },
new Character { Name = "Mazuk", Occupation = "King of Thipse", Residence = "Thipse" },
new Character { Name = "Fragru", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Garmanar", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Ajax", Occupation = "Mercenary Leader", Residence = "Mercenary Camp" },
new Character { Name = "Rick", Occupation = "Researcher", Residence = "Unknown" },
new Character { Name = "Morty", Occupation = "Student", Residence = "Tree of Life" },
new Character { Name = "Tesla", Occupation = "Researcher", Residence = "Wardenclyffe" },
new Character { Name = "Murdoch", Occupation = "Detective", Residence = "Ruins" },
new Character { Name = "Duncan", Occupation = "Guard Captain", Residence = "Nexus Longhouse" },
new Character { Name = "Hannibal", Occupation = "General", Residence = "Varthek" },
new Character { Name = "Alexander the Awesome", Occupation = "King of Kinderyarn", Residence = "Flaxchop" },
new Character { Name = "Archimedes", Occupation = "Engineer", Residence = "Bractal" },
new Character { Name = "Guan Yu", Occupation = "Commander", Residence = "Wolk" },
new Character { Name = "Cicero", Occupation = "Jester", Residence = "Bractal Castle" },
new Character { Name = "Beatrix", Occupation = "Guard Captain", Residence = "Bractal Castle" },
new Character { Name = "Bard", Occupation = "Bard", Residence = "Peachstraw" },
new Character { Name = "Ash Ketchum", Occupation = "Beast Master", Residence = "Unknown" },
new Character { Name = "Mario", Occupation = "Plumber", Residence = "Unknown" },
new Character { Name = "Orngamorn", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Alice", Occupation = "Adventurer", Residence = "Ye Olde Taverne" },
new Character { Name = "Aithaluwa", Occupation = "Adventurer", Residence = "Ye Olde Taverne" },
new Character { Name = "Geralt", Occupation = "Adventurer", Residence = "Camp" },
new Character { Name = "Jaskier", Occupation = "Bard", Residence = "Camp" },
new Character { Name = "Marie Curie", Occupation = "Researcher", Residence = "Thipse" },
new Character { Name = "Isaac Newton", Occupation = "Teacher", Residence = "Thipse" },
new Character { Name = "Christopher Columbus", Occupation = "Explorer", Residence = "Lochtou" },
new Character { Name = "Arthur Pendragon", Occupation = "King of Louchtou", Residence = "Lochtou" },
new Character { Name = "Joan D'Arc", Occupation = "Soldier", Residence = "Nymenada" },
new Character { Name = "Leonardo Da Vinci", Occupation = "Inventor", Residence = "Jight" },
new Character { Name = "Charles Darwin", Occupation = "Observer", Residence = "Bractalia" },
new Character { Name = "Alan Turing", Occupation = "Genius", Residence = "Unknown" },
new Character { Name = "Weaver", Occupation = "Weaver", Residence = "Oasis" },
new Character { Name = "Farmer", Occupation = "Farmer", Residence = "Oasis" },
new Character { Name = "Elder", Occupation = "Teacher", Residence = "Oasis" },
new Character { Name = "Bandit", Occupation = "Thief", Residence = "Bandit Camp" },
new Character { Name = "Bandit Recruit", Occupation = "Thief", Residence = "Bandit Camp" },
new Character { Name = "Bandit Highwayman", Occupation = "Thief", Residence = "Bandit Camp" },
new Character { Name = "Bandit Leader", Occupation = "Thief", Residence = "Bandit Camp" },
new Character { Name = "Weaver", Occupation = "Weaver", Residence = "Tree of Life" },
new Character { Name = "Beastmaster", Occupation = "Beastmaster", Residence = "Tree of Life" },
new Character { Name = "Healer", Occupation = "Healer", Residence = "Tree of Life" },
new Character { Name = "Chemist", Occupation = "Chemist", Residence = "Tree of Life" },
new Character { Name = "Vagrant", Occupation = "Vagrant", Residence = "Ruins" },
new Character { Name = "Scavenger", Occupation = "Scavenger", Residence = "Ruins" },
new Character { Name = "Elder", Occupation = "Teacher", Residence = "Ruins" },
new Character { Name = "Good Son", Occupation = "Hunter", Residence = "Ruins" },
new Character { Name = "Barkeep", Occupation = "Barkeep", Residence = "Ye Olde Taverne" },
new Character { Name = "Aslo", Occupation = "Bard", Residence = "Ye Olde Taverne" },
new Character { Name = "Barmaid", Occupation = "Barmaid", Residence = "Ye Olde Taverne" },
new Character { Name = "Servant", Occupation = "Servant", Residence = "Ye Olde Taverne" },
new Character { Name = "Guard", Occupation = "Guard", Residence = "Ye Olde Taverne" },
new Character { Name = "Brans Wife", Occupation = "Farmer", Residence = "Brans Farmhouse" },
new Character { Name = "Stablemaster", Occupation = "Esquire", Residence = "Stables" },
new Character { Name = "Assistant", Occupation = "Assistant", Residence = "Stables" },
new Character { Name = "Cedalion", Occupation = "Blacksmith", Residence = "Blacksmith" },
new Character { Name = "Assistant", Occupation = "Assistant", Residence = "Blacksmith" },
new Character { Name = "Apprentice", Occupation = "Apprentice", Residence = "Blacksmith" },
new Character { Name = "Guard", Occupation = "Guard", Residence = "Blacksmith" },
new Character { Name = "Husband", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Wife", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Mercenary", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Vagrant Mercenary", Occupation = "Mercenary", Residence = "Mercenary Camp" },
new Character { Name = "Commander", Occupation = "Commander", Residence = "Nexus Longhouse" },
new Character { Name = "Captain", Occupation = "Captain", Residence = "Nexus Longhouse" },
new Character { Name = "Archer", Occupation = "Guard", Residence = "Nexus Longhouse" },
new Character { Name = "Guard", Occupation = "Guard", Residence = "Nexus Longhouse" },
new Character { Name = "Healer", Occupation = "Healer", Residence = "Temple" },
new Character { Name = "Priest", Occupation = "Priest", Residence = "Temple" },
new Character { Name = "Weaver", Occupation = "Weaver", Residence = "Nexus Weavery" },
new Character { Name = "Potter", Occupation = "Potter", Residence = "Nexus Pottery" },
new Character { Name = "Thomas", Occupation = "Archer", Residence = "Vagrant" },
new Character { Name = "Homer", Occupation = "Poet", Residence = "Unknown" }

            });
        }

        // Function to export all characters to separate JSON files
        private static void ExportCharactersToFile()
        {
            foreach (var character in charactersData)
            {
                string fileName = $"character_{charactersData.IndexOf(character) + 1}.json";
                ExportCharacter(character, fileName);
            }
        }

        private static void ExportCharacter(Character character, string fileName)
        {
            try
            {
                string savePath = Path.Combine("Psychosis", "Data", fileName);
                string serializedData = character.Serialize();
                File.WriteAllText(savePath, serializedData);
                WriteLine($"{character.Name} has been exported to {savePath}.");
            }
            catch (Exception e)
            {
                WriteLine($"Failed to export {character.Name}: {e.Message}");
            }
        }

        // Function to import a character from a JSON file
        private static Character ImportCharacter(string fileName)
        {
            try
            {
                string filePath = Path.Combine("Psychosis", "Data", fileName);
                string data = File.ReadAllText(filePath);
                Character character = new Character();
                character.Deserialize(data);
                WriteLine($"{character.Name} has been imported from {filePath}.");
                return character;
            }
            catch (Exception e)
            {
                WriteLine($"Failed to import character from {fileName}: {e.Message}");
                return null!;
            }
        }

        public void StartDialogue()
        {
            // Logic to start a conversation and display dialogue options
            Say("Hello, how can I help you?", ConsoleColor.Gray, 111);
            string response = ReadLine()!;
            File.AppendAllText("Dialogue.txt", $"{Name} said: {response}");
        }

        public void Greet()
        {
            Say($"Hello, my name is {Name}.", ConsoleColor.Gray, 111);
            string input = ReadLine()!;
            Say($"Nice to meet you, {input}.", ConsoleColor.Gray, 111);
            string input0 = ReadLine()!;
            File.AppendAllText("Greetlog.txt", $"{Name} greeted {input} with {input0}.");
        }

        public void Talk()
        {
            Say($"{output}", ConsoleColor.Gray, 111);
            string input = ReadLine()!;
            File.AppendAllText("Talklog.txt", $"{Name} talked about {input}.");
        }

        public void Trade()
        {
            Say($"Hello, my name is {Name}. I have {ItemAmount} {Item} for sale.", ConsoleColor.Gray, 111);
            string input = ReadLine()!;
            Say($"That will be {Silver} silver.", ConsoleColor.Gray, 111);
            string input0 = ReadLine()!;
            File.AppendAllText("Tradelog.txt", $"{Name} traded {input} for {input0} silver.");
        }

        public void Farewell()
        {
            Say($"Goodbye, {Name}.", ConsoleColor.Gray, 111);
            string input = ReadLine()!;
            File.AppendAllText("Farewelllog.txt", $"{Name} said goodbye to {input}.");
        }

        public void Leave()
        {
            Say($"Goodbye, {Name}.", ConsoleColor.Gray, 111);
            File.AppendAllText("Leavelog.txt", $"{Name} left.");
        }

        public void DisplayCharacter()
        {
            WriteLine($"Name: {Name}");
            WriteLine($"Age: {Age}");
        }

        public void DisplayInventory()
        {
            WriteLine($"Name: {Name}");
            WriteLine($"Item Amount: {ItemAmount}");
            WriteLine($"Silver: {Silver}");
        }

        public void Work()
        {
            Say($"Hello, my name is {Name}. I am working right now.", ConsoleColor.Gray, 111);
            string input = ReadLine()!;
            File.AppendAllText("Worklog.txt", $"{Name} worked and {input}.");
        }
    }
}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aithaluwa
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Character(string name, int level)
        {
            Name = name;
            Level = level;
            Health = 100;
        }

        public void Attack(Character target)
        {
            Console.WriteLine("{0} is attacking {1}", Name, target.Name);
            target.Health -= 10;
        }

        public void Heal(Character target)
        {
            Console.WriteLine("{0} is healing {1}", Name, target.Name);
            target.Health += 10;
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Level: {0}", Level);
            Console.WriteLine("Health: {0}", Health);
        }
    }
}
