using System;

namespace IndexerDemo;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== C# INDEXERS DEMO ===\n");

        // ---------------------------------------------------------
        // 1. BASIC ARRAY INDEXER
        // ---------------------------------------------------------
        Console.WriteLine("--- 1. Basic Array Indexer ---");
        Team myTeam = new Team();
        
        // We use the object exactly like an array!
        myTeam[0] = "Alex"; 
        myTeam[1] = "John";
        
        Console.WriteLine("Player 1 is: " + myTeam[0]);
        myTeam[5] = "David"; // This will trigger our safety Error message!


        // ---------------------------------------------------------
        // 2. DICTIONARY INDEXER (String Parameter)
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 2. Dictionary Indexer ---");
        PhoneBook myPhoneBook = new PhoneBook();
        
        // We search and save using a string!
        myPhoneBook["Kamal"] = 771234567;
        myPhoneBook["Nimal"] = 719876543;

        Console.WriteLine("Kamal's Number: " + myPhoneBook["Kamal"]);


        // ---------------------------------------------------------
        // 3. MULTI-PARAMETER INDEXER (2D Grid)
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 3. Multi-Parameter Indexer ---");
        Spreadsheet excelSheet = new Spreadsheet();
        
        // Row 0, Column 2
        excelSheet[0, 2] = "Monthly Salary Data"; 
        Console.WriteLine("Data at [0, 2]: " + excelSheet[0, 2]);


        // ---------------------------------------------------------
        // 4. OVERLOADED INDEXERS
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 4. Overloaded Indexers ---");
        Library cityLibrary = new Library();
        cityLibrary.AddBook("Harry Potter");
        cityLibrary.AddBook("Lord of the Rings");

        // Using Indexer 1 (Passing an int)
        Console.WriteLine("Book at ID 1: " + cityLibrary[1]);

        // Using Indexer 2 (Passing a string)
        Console.WriteLine("Harry Potter is at ID: " + cityLibrary["Harry Potter"]);


        Console.WriteLine("\nAll indexer concepts tested successfully!");
    }
}