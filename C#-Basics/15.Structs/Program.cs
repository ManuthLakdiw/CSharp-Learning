using System;

namespace StructsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== C# STRUCTS DEMO ===\n");

            // ---------------------------------------------------------
            // 1. BASIC STRUCT
            // ---------------------------------------------------------
            Console.WriteLine("--- 1. Basic Struct ---");
            Point startPoint = new Point(10, 20);
            startPoint.PrintPosition();



            // ---------------------------------------------------------
            // 2. READONLY STRUCT
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 2. Readonly Struct ---");
            RgbColor pureRed = new RgbColor(255, 0, 0);
            pureRed.ShowColor();

            // ERROR: If you uncomment the line below, the program will crash!
            // pureRed.Red = 100; // You cannot change a readonly struct!


            // ---------------------------------------------------------
            // 3. COPY BEHAVIOR (Class vs Struct)
            // ---------------------------------------------------------
            Console.WriteLine("\n");
            CopyDemo demo = new();
            demo.TestCopyBehavior();

        
            

        }
    }
}
