using System;

namespace Concepts.EncapsulationDemo;

public class Student
{
    // 1. The PRIVATE FIELD (The hidden data)
    // We use '_' to tell other programmers this is a hidden, private variable.
    private int _age;

    // 2. The PUBLIC PROPERTY (The safe door)
    // We use a Capital letter for the property.
    public int Age
    {
        get
        {
            // When someone wants to READ the age, we open the door and give them '_age'
            return _age;
        }
        set
        {
            // When someone wants to WRITE a new age, we check if it is safe first!
            // 'value' is a magic C# word that holds the new number the user typed.
            if (value >= 0)
            {
                _age = value; // It is safe! Save it.
            }
            else
            {
                // Validation: Block bad data!
                Console.WriteLine("Validation Error: Age cannot be a negative number!");
            }
        }
    }
}