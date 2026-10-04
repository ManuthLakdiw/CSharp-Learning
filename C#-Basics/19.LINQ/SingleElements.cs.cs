using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo;

public class SingleElementsDemo
{
    public void Run()
    {
        Console.WriteLine("\n--- 5. Single Elements (Null Handling) ---");
        List<Product> products = DataStore.GetProducts();

        // SAFE: FirstOrDefault
        // Finds the first match. If nothing is found, it returns 'null' (Does NOT crash)
        var cheapItem = products.FirstOrDefault(p => p.Price < 10);
        Console.WriteLine($"Cheap item found: {cheapItem?.Name}");

        // Searching for something that doesn't exist
        var car = products.FirstOrDefault(p => p.Category == "Vehicles");
        
        if (car == null)
        {
            Console.WriteLine("Car was not found! (Safely handled null)");
        }

        // ==========================================
        // DANGER ZONE (Do not uncomment!)
        // ==========================================
        // var plane = products.First(p => p.Category == "Airplanes"); 
        // THIS WILL CRASH! System.InvalidOperationException: Sequence contains no matching element.
    }
}