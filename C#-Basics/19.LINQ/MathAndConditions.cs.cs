using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo;

public class MathAndConditionsDemo
{
    public void Run()
    {
        Console.WriteLine("\n--- 4. Math and Conditions ---");
        List<Product> products = DataStore.GetProducts();

        // MATH
        int totalValue = products.Sum(p => p.Price);
        int maxPrice = products.Max(p => p.Price);
        int electronicCount = products.Count(p => p.Category == "Electronics");

        // CONDITIONS (Returns boolean)
        bool hasFreeItems = products.Any(p => p.Price == 0); // Is there at least one?
        bool allCostMoney = products.All(p => p.Price > 0);  // Do ALL items cost money?

        Console.WriteLine($"Total Inventory Value: ${totalValue}");
        Console.WriteLine($"Most Expensive Item: ${maxPrice}");
        Console.WriteLine($"Total Electronic Items: {electronicCount}");
        Console.WriteLine($"Are all items > $0? : {allCostMoney}");
    }
}