using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConcurrencyDemo;

public class ParallelProgramming
{
    public void RunParallelForEach()
    {
        Console.WriteLine("\n--- Parallel.ForEach Demo ---");
        
        List<int> numbers = Enumerable.Range(1, 10).ToList();

        // This uses MULTIPLE CPU CORES at the same time! 
        // Warning: The output will NOT be in order (1, 2, 3...). It will be random!
        Parallel.ForEach(numbers, num =>
        {
            Console.WriteLine($"Processing number {num} on Thread {Environment.CurrentManagedThreadId}");
        });
    }

    public void RunPLinq()
    {
        Console.WriteLine("\n--- PLINQ (Parallel LINQ) Demo ---");
        
        // A large collection
        List<int> largeList = Enumerable.Range(1, 1000000).ToList();

        // Just add .AsParallel() to make LINQ run on multiple CPU cores!
        var evenNumbers = largeList
                            .AsParallel() 
                            .Where(n => n % 2 == 0)
                            .ToList();

        Console.WriteLine($"Found {evenNumbers.Count} even numbers extremely fast!");
    }
}