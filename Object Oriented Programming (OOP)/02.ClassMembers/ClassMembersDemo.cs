using System;

namespace ClassMembers
{
    // =========================================================
    // THE CLASS BLUEPRINT
    // =========================================================
    public class Robot
    {
        // ---------------------------------------------------------
        // 1. FIELDS (The hidden raw data)
        // We make them private so no one can mess with them directly.
        // ---------------------------------------------------------
        private string modelName;
        private int batteryLevel;

        // ---------------------------------------------------------
        // 2. CONSTRUCTOR (The Builder)
        // Runs automatically when 'new Robot()' is called.
        // ---------------------------------------------------------
        public Robot(string name)
        {
            // Set starting values
            modelName = name;
            batteryLevel = 100; // Starts fully charged
            Console.WriteLine($"[System] {modelName} created and fully charged.");
        }

        // ---------------------------------------------------------
        // 3. PROPERTIES (The Smart Gatekeepers - C# Special Feature!)
        // ---------------------------------------------------------
        
        // Auto-Property (The short way. C# creates the hidden field secretly)
        public string Owner { get; set; } 

        // Full Property (The safe way. Protects the batteryLevel field)
        public int Battery
        {
            get 
            { 
                // When someone asks for the battery, we give them the private field
                return batteryLevel; 
            }
            set 
            { 
                // When someone tries to change the battery, we check it first!
                // 'value' is a magic C# word for "the data the user is trying to save"
                if (value >= 0 && value <= 100)
                {
                    batteryLevel = value;
                }
                else
                {
                    Console.WriteLine("[Error] Battery must be between 0 and 100!");
                }
            }
        }

        // ---------------------------------------------------------
        // 4. METHODS (The Actions)
        // ---------------------------------------------------------
        public void Speak()
        {
            Console.WriteLine($"Hello, my owner is {Owner}. My battery is at {Battery}%.");
        }
    }

    // =========================================================
    // THE MAIN PROGRAM
    // =========================================================
    public class ClassMembersDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("=== C# CLASS MEMBERS DEEP DIVE ===\n");

            // 1. Constructor runs automatically here
            Robot myBot = new Robot("T-800");

            // 2. Using an Auto-Property (Looks like a variable, but is safe!)
            myBot.Owner = "Manuth";

            // 3. Using the Full Property
            // We try to set the battery to 200. The 'set' block will block it!
            myBot.Battery = 200; 

            // We set the battery to a valid number. The 'set' block allows it!
            myBot.Battery = 80;

            // 4. Using a Method
            myBot.Speak();

            Console.WriteLine();
        }
    }
}