using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo;

public class FilterAndSelectDemo
{
    public void Run()
    {
        Console.WriteLine("\n--- 2. Filtering and Selecting ---");
        List<Product> products = DataStore.GetProducts();

        // WHERE: Filtering data
        var electronics = products.Where(p => p.Category == "Electronics").ToList();

        // SELECT: Transforming data (Extracting ONLY the Names)
        // Notice the return type is List<string>, not List<Product>!
        List<string> foodNames = products
                                    .Where(p => p.Category == "Food")
                                    .Select(p => p.Name)
                                    .ToList();

        Console.WriteLine("Food Items:");
        foreach (var name in foodNames)
        {
            Console.WriteLine($"- {name}");
        }
    }
}