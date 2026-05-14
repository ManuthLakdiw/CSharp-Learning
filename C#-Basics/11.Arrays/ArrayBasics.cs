using System;

namespace Arrays.Examples
{
    public class ArrayBasics
    {
        public static void RunBasics()
        {
            Console.WriteLine("=== 1. ARRAY BASICS & INITIALIZATION ===");

            // Method 1: Build first, add data later (The Long Way)
            int[] ages = new int[3]; 
            ages[0] = 25;
            ages[1] = 30;
            ages[2] = 22;

            // Method 2: The Old Standard (Using curly braces { } )
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // Method 3: The Modern Standard (Using square brackets [ ] - C# 12+)
            double[] balance = [ 100.50, 200.00, 50.00, 1500.75 ];

            // Concept: Array Indexing (Getting a single value out)
            double mySalary = balance[3]; // Gets the 4th item (1500.75)

            Console.WriteLine("The car at index 1 is: " + cars[1]);
            Console.WriteLine("The salary from the modern array is: $" + mySalary);
            Console.WriteLine();
        }
    }
}