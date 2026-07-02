using System;

namespace Concepts.InheritanceDemo;

// 1. GRANDPARENT
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("I am eating food.");
    }
}

// 2. PARENT
// Dog is the child of Animal
public class Dog : Animal 
{
    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

// 3. CHILD
// Puppy is the child of Dog. 
// It gets Bark() from Dog AND Eat() from Animal!
public class Puppy : Dog 
{
    public void Weep()
    {
        Console.WriteLine("Weeping like a cute puppy.");
    }
}