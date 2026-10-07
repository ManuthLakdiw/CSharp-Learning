using System;
using System.Threading.Tasks;

namespace ConcurrencyDemo;

public class ThreadSafetyAndLocks
{
    private int _bankBalance = 0;
    
    // The Padlock object used to lock the door
    private readonly object _padlock = new object();

    public async Task RunSafeCodeAsync()
    {
        Console.WriteLine("\n--- Thread Safety (Lock) Demo ---");
        _bankBalance = 0; // Reset

        // Run 2 threads at the exact same time
        Task t1 = Task.Run(() => AddMoneySafe());
        Task t2 = Task.Run(() => AddMoneySafe());

        await Task.WhenAll(t1, t2);

        // Because we used 'lock', the output will ALWAYS be exactly 200,000!
        Console.WriteLine($"Final Bank Balance: ${_bankBalance}");
    }

    private void AddMoneySafe()
    {
        for (int i = 0; i < 100000; i++)
        {
            // Only 1 thread can enter this block at a time. The other must wait outside.
            lock (_padlock)
            {
                _bankBalance++;
            } // Automatically unlocks here
        }
    }
}