using System;
using System.Threading.Tasks;

namespace ConcurrencyDemo;

public class IoVsCpuBound
{
    // I/O-BOUND WORK: Just waiting for an outside system.
    // NO new threads are created. We just use 'await'.
    public async Task FetchDatabaseDataAsync()
    {
        Console.WriteLine("\n[I/O Bound]: Requesting data from Database...");
        await Task.Delay(2000); // Waiting for the database...
        Console.WriteLine("[I/O Bound]: Database replied!");
    }

    // CPU-BOUND WORK: Heavy Math calculations.
    // We MUST use Task.Run() to hire a new worker from the Thread Pool!
    public async Task CalculateHeavyMathAsync()
    {
        Console.WriteLine("\n[CPU Bound]: Starting heavy Math...");

        // We give this hard work to a background Thread Pool worker
        await Task.Run(() =>
        {
            long total = 0;
            for (long i = 0; i < 2_000_000_000; i++)
            {
                total += i; // The CPU is sweating here!
            }
            Console.WriteLine($"[CPU Bound]: Math finished! Total is {total}");
        });
    }
}