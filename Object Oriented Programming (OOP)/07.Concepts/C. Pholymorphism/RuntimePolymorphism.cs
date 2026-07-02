using System;

namespace Concepts.PolymorphismDemo;

// THE PARENT
public class Animal
{
    // 1. We MUST use 'virtual' to unlock this method
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a generic sound.");
    }
}

// THE CHILD
public class Dog : Animal
{
    // 2. We use 'override' to replace the parent's code
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof! Woof!");
    }
}

// ANOTHER CHILD
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow! Meow!");
    }
}