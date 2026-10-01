using System;

namespace RecordsDemo;

// 1. THE DANGEROUS WAY (record struct)
// It is a struct (fast Stack memory), BUT it is NOT locked! 
// Anyone can accidentally change the data.
public record struct DangerousCoordinate(int X, int Y);


// 2. THE SAFE WAY (readonly record struct)
// This is fast (Stack memory) AND completely locked (Immutable)!
// Senior developers always use this.
public readonly record struct SafeCoordinate(int X, int Y);


public class RecordStructDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- Record Structs ---");

        // Testing the Dangerous Struct
        DangerousCoordinate badPos = new DangerousCoordinate(10, 20);
        badPos.X = 999; // Oh no! The data was changed! 
        Console.WriteLine($"Dangerous Coordinate X changed to: {badPos.X}");


        // Testing the Safe Struct
        SafeCoordinate goodPos = new SafeCoordinate(10, 20);
        
        // goodPos.X = 999; // ERROR! The compiler stops this. It is safe!
        
        // If we want a new position, we MUST use 'with' to make a new copy.
        SafeCoordinate newGoodPos = goodPos with { X = 999 };
        
        Console.WriteLine($"Safe Coordinate Old X: {goodPos.X}");
        Console.WriteLine($"Safe Coordinate New X: {newGoodPos.X}");
    }
}