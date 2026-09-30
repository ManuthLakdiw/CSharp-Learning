using System;

namespace StructsDemo;

// 1. BASIC STRUCT
// This represents a single logical value (A point on a screen).
// It is very small (Only 8 bytes total: 4 for X, 4 for Y).
public struct Point
{
    public int X;
    public int Y;

    // Structs can have constructors!
    // But you MUST assign a value to every single field inside it.
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void PrintPosition()
    {
        Console.WriteLine($"Current Position: X={X}, Y={Y}");
    }
}