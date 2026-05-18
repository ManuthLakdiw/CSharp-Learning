using System;

namespace Constructors
{
    public class Player
    {
        public string Username;
        public int Level;

        // =========================================================
        // 1. PARAMETERLESS (DEFAULT) CONSTRUCTOR
        // We MUST write this explicitly if we want 'new Player()' to work,
        // because we also have a Parameterized constructor below!
        // =========================================================
        public Player()
        {
            Username = "Guest";
            Level = 1;
            Console.WriteLine("Default Constructor Called: Guest player created.");
        }

        // =========================================================
        // 2. PARAMETERIZED CONSTRUCTOR (Overload 1)
        // Forces the user to give a name.
        // =========================================================
        public Player(string newName)
        {
            Username = newName;
            Level = 1;
            Console.WriteLine($"Parameterized Constructor Called: {Username} joined.");
        }

        // =========================================================
        // 3. MULTIPLE PARAMETERIZED CONSTRUCTOR (Overload 2)
        // Forces the user to give a name AND a starting level.
        // =========================================================
        public Player(string newName, int startLevel)
        {
            Username = newName;
            Level = startLevel;
            Console.WriteLine($"Pro Constructor Called: {Username} started at Level {Level}.");
        }
    }

    public class ConstructorDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("=== CONSTRUCTORS & OVERLOADING ===\n");

            // 1. Calls the Parameterless (Default) Constructor
            Player p1 = new Player(); 

            // 2. Calls the Parameterized Constructor (1 argument)
            Player p2 = new Player("Manuth"); 

            // 3. Calls the Overloaded Parameterized Constructor (2 arguments)
            Player p3 = new Player("Alex_Pro", 50); 

            Console.WriteLine();
        }
    }
}