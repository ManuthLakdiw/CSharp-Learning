using System;

namespace Concepts.InterfaceDemo;

// 1. THE INTERFACE (The Rulebook)
// We use 'I' at the beginning of the name to show it is an Interface.
public interface IVehicle
{
    // A Property Rule: The class MUST have a Brand property.
    string Brand { get; set; }

    // A Method Rule: The class MUST have a StartEngine method. (No body here!)
    void StartEngine();
}

// 2. THE CLASS (Signing the Contract)
public class Car : IVehicle
{
    public string Brand { get; set; } = "Toyota";

    // We MUST build this method, or the computer will give an error!
    public void StartEngine()
    {
        Console.WriteLine($"{Brand} Car: Vroom! Engine started.");
    }
}