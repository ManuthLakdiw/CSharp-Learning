using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo;

public class SyntaxDemo
{
    public void Run()
    {
        Console.WriteLine("--- 1. Query vs Method Syntax ---");
        List<Product> products = DataStore.GetProducts();

        // 1. QUERY SYNTAX (Looks like SQL)
        var expensiveQuery = from p in products
                             where p.Price > 100
                             select p;


        Console.WriteLine("Query Syntax Results (Price > 100):");
        foreach (var item in expensiveQuery)
        {
            Console.WriteLine($"- {item.Name} (${item.Price})");
        }


        // 2. METHOD SYNTAX (The Industry Standard)
        var expensiveMethod = products.Where(p => p.Price > 100).ToList();


        Console.WriteLine("Method Syntax Results (Price > 100):");
        foreach (var item in expensiveMethod)
        {
            Console.WriteLine($"- {item.Name} (${item.Price})");
        }
    }
}