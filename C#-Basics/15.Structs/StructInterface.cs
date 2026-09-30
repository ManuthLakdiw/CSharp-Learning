using System;

namespace StructsDemo;

// An Interface (A rulebook)
public interface IMovable
{
    void Move(int distance);
}

// Structs CANNOT inherit classes, but they CAN implement Interfaces!
public struct CharacterStats : IMovable
{
    public string Name;

    public void Move(int distance)
    {
        Console.WriteLine($"{Name} ran {distance} meters quickly!");
    }
}