using System;

namespace StructsDemo;

// A Reference Type (Lives on the Heap)
public class PlayerClass
{
    public int Score;
}

// A Value Type (Lives on the fast Stack)
public struct PlayerStruct
{
    public int Score;
}

public class CopyDemo
{
    public void TestCopyBehavior()
    {
        Console.WriteLine("--- Class vs Struct Copy Behavior ---");

        // 1. TESTING THE CLASS (Reference Type)
        PlayerClass class1 = new PlayerClass { Score = 100 };
        PlayerClass class2 = class1; // This SHARES the memory!
        
        class2.Score = 999; // Changing the copy...
        
        Console.WriteLine($"Class Original Score: {class1.Score}"); // Danger! Original changed to 999!


        // 2. TESTING THE STRUCT (Value Type)
        PlayerStruct struct1 = new() { Score = 100 };
        PlayerStruct struct2 = struct1; // This makes a BRAND NEW perfect copy!
        
        struct2.Score = 999; // Changing the copy...
        
        Console.WriteLine($"Struct Original Score: {struct1.Score}"); // Safe! Original is still 100!
    }
}