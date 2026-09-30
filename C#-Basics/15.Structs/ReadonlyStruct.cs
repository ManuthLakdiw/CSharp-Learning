using System;

namespace StructsDemo;

// 2. READONLY STRUCT (Immutable)
// The 'readonly' keyword locks the entire struct. 
// Once created, the values can NEVER be changed!
public readonly struct RgbColor
{
    // Properties must only have 'get' (no 'set' allowed!)
    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }

    public RgbColor(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public void ShowColor()
    {
        Console.WriteLine($"Color -> R: {Red}, G: {Green}, B: {Blue}");
    }
}