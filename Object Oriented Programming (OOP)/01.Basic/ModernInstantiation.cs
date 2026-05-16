using System;

namespace OOP_Basics
{
    // A simple class to test with
    public class Person
    {
        public string Name;
        public int Age;
        public string Country = "Unknown"; // Default value

        // Parameterized Constructor
        public Person(string name)
        {
            Name = name;
        }

        // Empty Constructor
        public Person() { }
    }

    public class ModernInstantiation
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== TARGET-TYPED NEW & OBJECT INITIALIZERS ===\n");

            // ---------------------------------------------------------
            // 1. THE OLD WAY (Classic C# and Java style)
            // ---------------------------------------------------------
            Person p1 = new Person();
            p1.Name = "Alice";
            p1.Age = 25;
            Console.WriteLine($"Old Way: {p1.Name} is {p1.Age}");

            // ---------------------------------------------------------
            // 2. OBJECT INITIALIZER (C# 3.0)
            // We set the properties immediately inside { }
            // Notice we didn't set 'Country'. It will stay "Unknown".
            // ---------------------------------------------------------
            Person p2 = new Person() 
            { 
                Name = "Bob", 
                Age = 30 
            };
            Console.WriteLine($"Initializer: {p2.Name} is {p2.Age} from {p2.Country}");

            // ---------------------------------------------------------
            // 3. TARGET-TYPED NEW EXPRESSION (C# 9.0)
            // We drop the class name on the right side!
            // ---------------------------------------------------------
            Person p3 = new(); // The computer knows it's a Person!
            p3.Name = "Charlie";

            // Passing arguments to a parameterized constructor using new()
            Person p4 = new("David"); 
            Console.WriteLine($"Target-Typed: {p4.Name}");

            // ---------------------------------------------------------
            // 4. THE ULTIMATE COMBO (new() + Object Initializer)
            // This is what your IDE suggested!
            // ---------------------------------------------------------
            Person p5 = new()
            {
                Name = "Eve",
                Age = 22,
                Country = "Sri Lanka"
            };
            Console.WriteLine($"The Combo: {p5.Name}, {p5.Age}, {p5.Country}");
        }
    }
}