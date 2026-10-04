using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo;

public class GroupAndChainDemo
{
    public void Run()
    {
        Console.WriteLine("\n--- 6. Grouping and Chaining ---");
        List<Product> products = DataStore.GetProducts();

        // 1. GROUPING
        // We group all items by their Category
        var groupedByCategory = products.GroupBy(p => p.Category).ToList();

        Console.WriteLine("Grouped Products:");
        foreach (var group in groupedByCategory)
        {
            Console.WriteLine($"[{group.Key}] has {group.Count()} items.");
        }

        // 2. CHAINING (Putting it all together)
        // Find Electronics -> Sort by Price -> Get only Names -> Convert to List
        List<string> topElectronics = products
            .Where(p => p.Category == "Electronics")
            .OrderByDescending(p => p.Price)
            .Select(p => p.Name)
            .ToList();

        Console.WriteLine("\nChained Results (Top Electronics by Name):");
        foreach (var name in topElectronics)
        {
            Console.WriteLine($"- {name}");
        }
    }
}