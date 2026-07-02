using System;

namespace Concepts.InheritanceDemo;

// 1. INTERFACE 1 (Contract 1)
// We use a capital 'I' at the start to show it is an Interface
public interface IFlyable
{
    void Fly(); // Just the rule. No code body inside!
}

// 2. INTERFACE 2 (Contract 2)
public interface ISwimmable
{
    void Swim(); // Just the rule.
}

// 3. THE DUAL-INHERITANCE CLASS
// The Duck signs BOTH contracts!
public class Duck : IFlyable, ISwimmable
{
    // The duck MUST build the code for both rules!
    public void Fly()
    {
        Console.WriteLine("The duck is flapping its wings in the sky!");
    }

    public void Swim()
    {
        Console.WriteLine("The duck is paddling its feet in the water!");
    }
}