using System;
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
