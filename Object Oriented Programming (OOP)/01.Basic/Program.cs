using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("=== INTRODUCTION TO OOP ===\n");

            // // 2. CREATE AN OBJECT (The Real Thing)
            // // We use the Class name, give our object a name, and use the 'new' keyword.

            // Car myFirstCar = new Car();
            // // 'myFirstCar' is now a real object inside the computer!

            // // ---------------------------------------------------------
            // // HOW TO USE THE OBJECT (The Dot '.' Operator)
            // // We use a dot (.) to look inside the object.
            // // ---------------------------------------------------------

            // Console.WriteLine("--- Checking Attributes ---");
            // // Looking at the attributes (variables)
            // Console.WriteLine("Car Brand: " + myFirstCar.brand);
            // Console.WriteLine("Car Color: " + myFirstCar.color);
            // Console.WriteLine("Doors: " + myFirstCar.numberOfDoors);

            // Console.WriteLine("\n--- Using Methods ---");
            // // Telling the object to do an action (methods)
            // myFirstCar.Drive();
            // myFirstCar.Honk();

            // // ---------------------------------------------------------
            // // THE POWER OF OOP: REUSABILITY
            // // We can build ANOTHER completely separate car using the same blueprint!
            // // ---------------------------------------------------------
            // Console.WriteLine("\n--- Creating a Second Object ---");

            // Car mySecondCar = new Car();

            // // We can change the attributes of this specific object
            // mySecondCar.color = "Blue";
            // mySecondCar.brand = "Ford";

            // mySecondCar.Drive(); // This will print: "The Blue Ford is driving! Vroom!"

            // Console.WriteLine("\nOOP Basics Execution Finished!");

            ModernInstantiation.RunExamples();
        }
    }
}