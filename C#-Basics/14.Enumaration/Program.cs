using System;

namespace EnumDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== C# ENUMS DEMO ===\n");

        // ---------------------------------------------------------
        // 1. BASIC ENUM & SWITCH
        // ---------------------------------------------------------
        Console.WriteLine("--- 1. Basic Enum ---");
        Order myOrder = new Order { CustomerName = "Manuth", Status = OrderStatus.Processing };
        myOrder.PrintOrderUpdate();


        // ---------------------------------------------------------
        // 2. ENUM VALUES & CASTING
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 2. Enum Values & Casting ---");
        ErrorHandler handler = new ErrorHandler();
        handler.ShowErrorDetails(ErrorCode.NotFound);


        // ---------------------------------------------------------
        // 3. ENUM PARSING (TryParse)
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 3. Enum Parsing ---");
        SecuritySystem sec = new SecuritySystem();
        sec.AssignRole("Admin");      // Success
        sec.AssignRole("SuperUser");  // Fails safely without crashing


        // ---------------------------------------------------------
        // 4. FLAGS ENUM (Combinations)
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 4. Flags Enum ---");
        FileManager fm = new FileManager();
        fm.CheckPermissions();


        // ---------------------------------------------------------
        // 5. ENUM EXTENSION METHODS
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 5. Enum Extension Methods ---");
        TrafficLight currentLight = TrafficLight.Green;
        
        // MAGIC! We can call our custom method directly on the enum object!
        string instruction = currentLight.GetDrivingInstruction();
        Console.WriteLine(instruction);


        Console.WriteLine("\nAll enum concepts tested successfully!");
    }
}