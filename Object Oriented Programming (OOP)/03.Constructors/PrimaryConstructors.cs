using System;

namespace Constructors.Primary
{
    // =========================================================
    // 1. THE PRIMARY CONSTRUCTOR (The VIP Engine)
    // The parameters go directly next to the class name!
    // =========================================================
    public class Player(string username, int age)
    {
        // ---------------------------------------------------------
        // RULE 1: EXPOSING SECRET DATA
        // 'username' and 'age' are private. The outside world cannot see them.
        // We create public properties to let the outside world read them.
        // ---------------------------------------------------------
        public string PlayerName { get; } = username;
        public int PlayerAge { get; } = age;

        // ---------------------------------------------------------
        // RULE 2: THE CHAINING RULE (: this)
        // If we make a normal (secondary) constructor, it MUST pass 
        // data up to the Primary Constructor using ': this()'
        // Here, if the user only gives a name, we pass '18' as the default age!
        // ---------------------------------------------------------
        public Player(string onlyName) : this(onlyName, 18)
        {
            Console.WriteLine("[System] Second constructor used. Age automatically set to 18.");
        }

        // ---------------------------------------------------------
        // RULE 3: DIRECT ACCESS IN METHODS
        // Because 'username' and 'age' are Primary Constructor parameters,
        // the computer secretly saves them. Any method can use them directly!
        // ---------------------------------------------------------
        public void ShowStats()
        {
            Console.WriteLine($"Player Stats -> Name: {username}, Age: {age}");
        }
    }

    // =========================================================
    // RULE 4: EMPTY PRIMARY CONSTRUCTOR
    // You can use empty brackets () if you just want a default constructor!
    // =========================================================
    public class GameSettings() 
    {
        public string Difficulty { get; set; } = "Normal";
    }

    // =========================================================
    // THE MAIN PROGRAM TO TEST EVERYTHING
    // =========================================================
    public class PrimaryConstructorDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("=== C# 12 PRIMARY CONSTRUCTORS ===\n");

            // --- TEST 1: Using the Primary Constructor directly ---
            Console.WriteLine("--- Creating Player 1 (Providing both Name and Age) ---");
            Player p1 = new Player("ProGamer99", 25);
            p1.ShowStats();
            
            // Testing the public Property we made
            Console.WriteLine("Reading public property directly: " + p1.PlayerName);

            Console.WriteLine("\n--- Creating Player 2 (Providing only Name) ---");

            // --- TEST 2: Using the Secondary Constructor ---
            // We only provide the name. The secondary constructor catches it, 
            // and passes "18" to the Primary Constructor using the :this() rule!
            Player p2 = new Player("Newbie");
            p2.ShowStats(); // It will print Age: 18

            Console.WriteLine("\n--- Creating Empty Object ---");

            // --- TEST 3: Using the Empty Primary Constructor ---
            GameSettings settings = new GameSettings();
            Console.WriteLine($"Settings loaded: {settings.Difficulty} mode.");

            Console.WriteLine();
        }
    }
}