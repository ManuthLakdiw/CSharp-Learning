using System;

namespace Concepts.InheritanceDemo;

// 1. THE SINGLE PARENT
public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Vroom! Engine started.");
    }
}

// 2. CHILD 1
public class Car : Vehicle
{
    public void PlayRadio()
    {
        Console.WriteLine("Playing music in the car.");
    }
}

// 3. CHILD 2
public class Truck : Vehicle
{
    public void CarryHeavyLoad()
    {
        Console.WriteLine("Carrying a lot of heavy boxes.");
    }
}