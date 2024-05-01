using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static Psychosis.TextAnimation;

public class CharacterModule
{
    public static string Username { get; private set; }

    public static void Main(string[] args)
    {
        try
        {
            // Initialize the game
            InitializeGame();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    /// <summary>
    /// Function to initialize the game.
    /// </summary>
    public static void InitializeGame()
    {
        // Display game title and play dead animation
        GameTitle();
        PlayDeadAnimation();
        Say("Initializing game...", ConsoleColor.White, 50);


        // Display welcome message in yellow color
        DisplayMessage("Let There Be Light!!", ConsoleColor.Yellow);
        WaitForKey();

        // Initialize game components
        InitializeComponents();
    }

    /// <summary>
    /// Function to initialize game components.
    /// </summary>
    public static void InitializeComponents()
    {
        // Create a new character
        Character player = new Character("character");
        player.Name = Username;

        // Set the character's location
        player.Location = new Location(0, 0, 0);

        // Initialize and display character statistics
        DisplayCharacterStatistics();

        // Display the Text User Interface
        Console.Clear();
        TUI();
        WaitForKey();

        // Display a message with a custom color
        DisplayMessage("Welcome to the game!", ConsoleColor.Red);
        WaitForKey();

        // Display a message with a custom color
        Say("Initializing game components...", ConsoleColor.Yellow, 42);

        // Display a message with a custom color
        DisplayMessage("Game components initialized successfully!", ConsoleColor.Green);
        WaitForKey();

        // Display a message with a custom color
        DisplayMessage("Game ready to play!", ConsoleColor.Blue);

        // initialize HTML character.html
        FileStream hTML = new FileStream("character.html", FileMode.Open);

        Console.Clear();
        TUI();
        WaitForKey();
    }

    /// <summary>
    /// Function to display character statistics.
    /// </summary>
    public static void DisplayCharacterStatistics()
    {
        Dictionary<string, string> characterStats = new Dictionary<string, string>
        {
            { "Inventory", "" },
            { "Map(7*8)", "" },
            { "Text output", "" },
            { "Notifications", "" },
            { "Character Quests", "" },
            { "List", "" },
            { "Movement", "" },
            { "Observation", "" },
            { "Run", "" },
            { "Text input", "" },
            { "Conversation", "" }
        };

        foreach (KeyValuePair<string, string> stat in characterStats)
        {
            Console.WriteLine($"{stat.Key}: {stat.Value}");
        }
    }

    public static void TUI()
    {
        DisplayMessage(@"
___==========================================/==\==================================================================___
| /                                           /\                                                                   \ |
|/                                            ||                                                                    \|
||                                            ||                                                                    ||
||                                            ||/                                                                   ||
||                                            |__================__/                                                ||
||                                            ||Character Statistics/                                               ||
||                                            |__\===================/===========================^=================__|
||                                            |\                                                 |                 \ |
||                                            ||                                                 |                  \|
||                                            ||                                                 |                  ||
||Inventory:                                  ||Map(7*8):                                        |                  ||
|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\|                  ||
|__============================================================================================__|                  ||
||_____________________________|_____________\__________________________________________________/|                  ||
||(C)onversation:              |__========__\                                                  / |                  ||
||                             |Text output:|                                                 / \|                  ||
||                             __=========__|_____________________________________________|__/_|/|List:             ||
||                                           ||                                           |_/|\__|__=============___/|
||(M)ovement        (O)bservation      (R)un ||                                           |/_  Character Quests:  _/ |
|__==========================================\/===========================================_\======================/  |
|                                            ||                                                                      |
|Text input:                                 ||Notifications:                                                        |
\__==========================================/\====================================================================__/
", ConsoleColor.Green);
    }



    public GameConfigDefaults Defaults { get; set; }
    public BootstrapConfig BootstrapConfig { get; set; }
    public bool WindowTitle { get; private set; }

    private GameConfigDefaults gameConfig;

    public GameConfigDefaults GetGameConfig()
    {
        return gameConfig;
    }

    private void SetGameConfig(GameConfigDefaults value)
    {
        gameConfig = value;
    }

    public void UpdateConfig(dynamic configData)
    {
        // Update the game configuration with the provided data
        SetGameConfig(configData);
    }

    public class GameConfigDefaults
    {
        // Game directories
        public string HomeDirectory { get; set; } = "C://robjam1990.ca/Psychosis/"; // Home directory
        public string ResourcesDirectory { get; set; } = "Psychosis/Resources/"; // Resources directory
        public string DataDirectory { get; set; } = "Psychosis/Data/"; // Data directory
        public string SaveDirectory { get; set; } = "Psychosis/Save/";    // Save directory
        public string LogDirectory { get; set; } = "Psychosis/Log/"; // Log directory
        public string ConfigDirectory { get; set; } = "Psychosis/Config/"; // Configuration directory
        public string TempDirectory { get; set; } = "Psychosis/Temp/";    // Temporary directory
        public string AssetDirectory { get; set; } = "Psychosis/Asset/"; // Asset directory
        public string ScriptDirectory { get; set; } = "Psychosis/Script/"; // Script directory
        public string PluginDirectory { get; set; } = "Psychosis/Plugin/"; // Plugin directory
        public string ModDirectory { get; set; } = "Psychosis/Mod/"; // Mod directory

        // Window settings
        public string WindowTitle { get; set; } = "Psychosis Window";   // Default window title
        public string WindowIcon { get; set; } = "Images/Thear.png";   // Default window icon
        public int MaxWindowWidth { get; set; } = 800; // Default maximum window width
        public int MaxWindowHeight { get; set; } = 600; // Default maximum window height
        public int InitialWindowWidth { get; set; } = 600; // Default initial window width
        public int InitialWindowHeight { get; set; } = 400; // Default initial window height
        public bool WindowResizable { get; set; } = true; // Default window resizable
        public bool WindowBorderless { get; set; } = false; // Default window borderless
        public bool WindowAlwaysOnTop { get; set; } = false;    // Default window always on top
        public bool WindowVSync { get; set; } = true; // Default window VSync

        // Rendering settings
        public int[] RenderDefaultBackgroundColor { get; set; } = new int[] { 255, 255, 255 }; // White color
        public int RenderDefaultLayer { get; set; } = 0;    // Default render layer
        public int RenderFPS { get; set; } = 60; // Default render FPS
        public bool RenderVSync { get; set; } = true; // Default render VSync
        public bool RenderFullscreen { get; set; } = false; // Default render fullscreen
        public bool RenderAntialiasing { get; set; } = true; // Default render antialiasing
        public bool RenderTexture { get; set; } = true; // Default render texture
        public bool RenderPostProcessing { get; set; } = true; // Default render post-processing
        public bool RenderBloom { get; set; } = true; // Default render bloom

        // Game features
        public bool LimbRemovalEnabled { get; set; } = true; // Added Limb Removal
        public bool EcosystemSimulationEnabled { get; set; } = true; // Added Ecosystem Simulation
        public bool NationBuildingEnabled { get; set; } = true; // Added Nation Building
        public bool SocialInfrastructureEnabled { get; set; } = true; // Added Social Infrastructure
        public bool BountySystemEnabled { get; set; } = true; // Added Bounty System
        public bool HierarchySystemEnabled { get; set; } = true; // Added Hierarchy System
        public bool IndividualLoyaltyEnabled { get; set; } = true; // Added Individual Loyalty
        public bool TerritoryBorderExpansionEnabled { get; set; } = true; // Added Territory Border Expansion
        public bool DayNightCycleEnabled { get; set; } = true; // Added Day-Night Cycle
        public bool ConstructionSystemEnabled { get; set; } = true; // Added Construction System
        public bool PrisonerSystemEnabled { get; set; } = true; // Added Prisoner System
        public bool HiringSystemEnabled { get; set; } = true; // Added Hiring System
        public bool SupplyAndDemandSystemEnabled { get; set; } = true; // Added Supply and Demand System
        public bool ResourceSystemEnabled { get; set; } = true; // Added Resource System
        public bool CraftingSystemEnabled { get; set; } = true; // Added Crafting System
        public bool SurvivalSystemEnabled { get; set; } = true; // Added Survival System
        public bool LearningAndTeachingSystemEnabled { get; set; } = true; // Added Learning and Teaching System
        public bool ObservationSystemEnabled { get; set; } = true; // Added Observation System
        public bool GeneticManipulationEnabled { get; set; } = true; // Added Genetic Manipulation
        public bool NeuralNetworkEnabled { get; set; } = true; // Added Neural Network
        public bool ContractBoardEnabled { get; set; } = true; // Added Contract Board
        public bool ModelStrategyEnabled { get; set; } = true; // Added Model Strategy
        public bool MercenaryEnabled { get; set; } = true; // Added Mercenary
        public bool CharacterEnabled { get; set; } = true; // Added Character
        public bool CharacterGrowthSystemEnabled { get; set; } = true; // Added Character Growth System
        public bool CharacterCustomizationEnabled { get; set; } = true;     // Added Character Customization
        public bool CharacterCreationEnabled { get; set; } = true; // Added Character Creation
        public bool CharacterDevelopmentEnabled { get; set; } = true; // Added Character Development
        public bool CharacterInteractionEnabled { get; set; } = true; // Added Character Interaction
        public bool CharacterManagementEnabled { get; set; } = true; // Added Character Management
        public bool CharacterProgressionEnabled { get; set; } = true; // Added Character Progression
        public bool CharacterStatisticsEnabled { get; set; } = true; // Added Character Statistics
        public bool CharacterTraitsEnabled { get; set; } = true; // Added Character Traits
        public bool CharacterSkillsEnabled { get; set; } = true; // Added Character Skills
        public bool CharacterInventoryEnabled { get; set; } = true; // Added Character Inventory
        public bool CharacterEquipmentEnabled { get; set; } = true; // Added Character Equipment
        public bool CharacterResourcesEnabled { get; set; } = true; // Added Character Resources
        public bool CharacterQuestsEnabled { get; set; } = true; // Added Character Quests
        public bool CharacterCombatEnabled { get; set; } = true; // Added Character Combat
        public bool CharacterDialogueEnabled { get; set; } = true; // Added Character Dialogue
    }
}

public class BootstrapConfig
{
    public string HomeDirectory { get; set; } = "./robjam1990.ca/Psychosis/"; // Home directory
    public string WindowTitle { get; set; } = "Psychosis Window";   // Default window title
    public int[] RenderDefaultBackgroundColor { get; set; } = new int[] { 255, 255, 255 }; // White color
}