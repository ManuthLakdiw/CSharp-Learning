using System;

namespace Concepts.InterfaceDemo;

public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

// MULTIPLE INHERITANCE
// The Duck class signs BOTH contracts safely!
public class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Duck: Flapping wings in the sky!");
    }

    public void Swim()
    {
        Console.WriteLine("Duck: Paddling feet in the water!");
    }
}