using System;

namespace OOP_Basics
{
    // 1. CREATE A CLASS (The Blueprint)
    // We use the 'class' keyword.
    public class Car
    {
        // ---------------------------------------------------------
        // ATTRIBUTES (What the object HAS)
        // These are variables inside the class.
        // ---------------------------------------------------------
        public string color = "Red";
        public string brand = "Toyota";
        public int numberOfDoors = 4;

        // ---------------------------------------------------------
        // METHODS (What the object DOES)
        // These are functions inside the class.
        // ---------------------------------------------------------
        public void Drive()
        {
            Console.WriteLine($"The {color} {brand} is driving! Vroom!");
        }

        public void Honk()
        {
            Console.WriteLine("Beep Beep!");
        }
    }
}