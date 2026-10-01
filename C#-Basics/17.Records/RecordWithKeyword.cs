using System;

namespace RecordsDemo;

// A basic immutable record
public record Product(string Name, double Price);

public class WithKeywordDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- The 'with' Keyword ---");

        // 1. Create the original record
        Product laptop = new Product("MacBook Air", 1000.00);
        Console.WriteLine($"Original Laptop: {laptop.Name} - ${laptop.Price}");

        // laptop.Price = 1200; // ERROR! Records are locked (immutable).

        // 2. Use 'with' to create a BRAND NEW copy with a changed price!
        Product updatedLaptop = laptop with { Price = 1200.00 };

        Console.WriteLine($"Updated Laptop: {updatedLaptop.Name} - ${updatedLaptop.Price}");
        Console.WriteLine($"Original is still safe: ${laptop.Price}");
    }
}