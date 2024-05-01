

namespace Psychosis
{
    // Define the characters data
    public class Character
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Residence { get; set; }
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
        public object Faction { get; set; } = null;

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
                Console.WriteLine($"{character.Name} has been exported to {savePath}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to export {character.Name}: {e.Message}");
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
                Console.WriteLine($"{character.Name} has been imported from {filePath}.");
                return character;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to import character from {fileName}: {e.Message}");
                return null;
            }
        }
    }
}