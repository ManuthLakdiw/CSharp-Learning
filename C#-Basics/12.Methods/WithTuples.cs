using System;

namespace Methods.Examples
{
    // A simple custom class to test putting Objects inside Tuples!
    public class Weapon
    {
        public string Name = "Sword";
    }

    public class TupleDeepDive
    {
        public static void RunTupleExamples()
        {
            Console.WriteLine("=== DEEP DIVE: C# VALUE TUPLES ===\n");

            // ---------------------------------------------------------
            // 1. DECLARATION & INITIALIZATION (Basic)
            // ---------------------------------------------------------
            Console.WriteLine("1. Basic Tuple (Using Item1, Item2):");
            
            // The () tells the compiler to create a ValueTuple struct
            (string, int) standardTuple = ("Alex", 100);
            
            Console.WriteLine($"Name: {standardTuple.Item1}, Score: {standardTuple.Item2}");

            // ---------------------------------------------------------
            // 2. NAMED TUPLES (Adding Name Tags)
            // ---------------------------------------------------------
            Console.WriteLine("\n2. Named Tuple:");
            
            // We give 'PlayerName' and 'Health' as custom names for easier reading
            (string PlayerName, int Health) heroTuple = ("Batman", 100);
            
            // Now we can use .PlayerName instead of .Item1!
            // Tuples are MUTABLE (We can change the values inside!)
            heroTuple.Health = 50; 
            
            Console.WriteLine($"Hero: {heroTuple.PlayerName}, Health: {heroTuple.Health}");

            // ---------------------------------------------------------
            // 3. OBJECTS INSIDE TUPLES
            // ---------------------------------------------------------
            Console.WriteLine("\n3. Objects inside Tuples:");
            
            Weapon mySword = new Weapon();
            
            // A tuple holding an integer AND a custom Class object!
            (int level, Weapon equip) inventory = (5, mySword);
            
            Console.WriteLine($"Level {inventory.level} using {inventory.equip.Name}");

            // ---------------------------------------------------------
            // 4. DECONSTRUCTION (Unpacking the bag instantly)
            // ---------------------------------------------------------
            Console.WriteLine("\n4. Deconstruction (Unpacking):");
            
            // We call a method that returns a Tuple
            // We instantly unpack the answer into two NEW variables!
            (string winningCar, int topSpeed) = GetRaceWinner();

            Console.WriteLine($"The winner is {winningCar} at {topSpeed} MPH!");

            Console.WriteLine();
        }

        // A Method that returns a ValueTuple (string, int)
        public static (string, int) GetRaceWinner()
        {
            // Returning the Tuple using ()
            return ("Ferrari", 210);
        }
    }
}