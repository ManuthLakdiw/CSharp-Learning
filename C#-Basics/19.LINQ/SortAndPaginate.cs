using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo;

public class SortAndPaginateDemo
{
    public void Run()
    {
        Console.WriteLine("\n--- 3. Sorting and Pagination ---");
        List<Product> products = DataStore.GetProducts();

        // SORTING: Order by Category, and THEN by Price (Highest to Lowest)
        var sorted = products
                        .OrderBy(p => p.Category)
                        .ThenByDescending(p => p.Price)
                        .ToList();

        // PAGINATION: Skip the first 2, and take the next 2
        var pageTwo = products.Skip(2).Take(2).ToList();

        Console.WriteLine("Pagination (Skip 2, Take 2):");
        foreach (var p in pageTwo)
        {
            Console.WriteLine($"- {p.Name}");
        }
    }
}