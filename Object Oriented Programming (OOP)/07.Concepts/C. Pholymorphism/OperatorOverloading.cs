using System;

namespace Concepts.PolymorphismDemo;

public class Box
{
    public int Weight { get; set; }

    public Box(int weight)
    {
        Weight = weight;
    }

    // OPERATOR OVERLOADING: Teaching the '+' sign how to add two Boxes together!
    // This is a feature C# has, but Java does not!
    public static Box operator +(Box b1, Box b2)
    {
        // We create a brand new box by combining the weights of the two boxes
        int newWeight = b1.Weight + b2.Weight;
        return new Box(newWeight);
    }
}