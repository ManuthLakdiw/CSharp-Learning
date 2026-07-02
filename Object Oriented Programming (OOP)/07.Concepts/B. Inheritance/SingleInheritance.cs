using System;

namespace Concepts.InheritanceDemo;

// 1. THE PARENT CLASS
public class Father
{
    // The child will automatically get this!
    public string FamilyName = "Smith"; 
    
    public void Work()
    {
        Console.WriteLine("Working hard for the family.");
    }
}

// 2. THE CHILD CLASS
// The colon (:) means Son inherits from Father
public class Son : Father
{
    public void Play()
    {
        Console.WriteLine("Playing video games.");
    }
}