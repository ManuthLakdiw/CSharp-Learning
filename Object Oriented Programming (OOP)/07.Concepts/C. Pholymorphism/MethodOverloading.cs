using System;

namespace Concepts.PolymorphismDemo;

public class Calculator
{
    // Method 1: Adds two numbers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: EXACT SAME NAME! But it takes THREE numbers (Different Signature)
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method 3: EXACT SAME NAME! But it takes decimal numbers (Different Parameters)
    public double Add(double a, double b)
    {
        return a + b;
    }
}