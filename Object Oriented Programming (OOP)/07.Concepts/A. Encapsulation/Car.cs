namespace Concepts.EncapsulationDemo;

public class Car
{
    // THE SHORT WAY (Auto-Implemented Property)
    // We do NOT write a private field. C# does it automatically in the background.
    public string Color { get; set; }

    // You can also give it a default value immediately!
    public string Model { get; set; } = "Toyota";
}