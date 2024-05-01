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
        Say("Initializing game components...", ConsoleColor.Yellow, 420);

        // Display a message with a custom color
        DisplayMessage("Game components initialized successfully!", ConsoleColor.Green);
        WaitForKey();

        // Display a message with a custom color
        DisplayMessage("Game ready to play!", ConsoleColor.Blue);

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
            { "Map(7*8)", "" }
            // Add more statistics as needed
        };

        foreach (KeyValuePair<string, string> stat in characterStats)
        {
            Console.WriteLine($"{stat.Key}: {stat.Value}");
        }
    }

    /// <summary>
    /// Function to display a message with specified color.
    /// </summary>
    /// <param name="message">The message to display.</param>
    /// <param name="color">The color of the message.</param>
    public static void DisplayMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
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
\__==========================================/\====================================================================__/", ConsoleColor.Green);
    }
}
