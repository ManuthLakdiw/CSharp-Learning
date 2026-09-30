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
        }
    }
}
