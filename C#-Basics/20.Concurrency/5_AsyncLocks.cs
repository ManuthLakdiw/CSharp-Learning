using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyDemo;

public class AsyncLocks
{
    private int _safeData = 0;
    
    // Create a bouncer that only allows 1 thread inside at a time
    private static readonly SemaphoreSlim _bouncer = new SemaphoreSlim(1, 1);

    public async Task RunSemaphoreDemoAsync()
    {
        Console.WriteLine("\n--- SemaphoreSlim (Async Lock) Demo ---");
        
        Task t1 = SafeAsyncMethodAsync("Thread 1");
        Task t2 = SafeAsyncMethodAsync("Thread 2");

        await Task.WhenAll(t1, t2);
        Console.WriteLine($"Final Data Value: {_safeData}");
    }

    private async Task SafeAsyncMethodAsync(string threadName)
    {
        Console.WriteLine($"{threadName} is waiting in line...");
        
        // Ask the Bouncer for permission to enter
        await _bouncer.WaitAsync();
        try
        {
            // --- CRITICAL SECTION ---
            Console.WriteLine($"{threadName} entered the locked room!");
            
            // We can safely use 'await' inside here! (Standard 'lock' cannot do this)
            await Task.Delay(1000); 
            _safeData++;
            
            Console.WriteLine($"{threadName} is leaving the room.");
        }
        finally
        {
            // ALWAYS tell the Bouncer you are leaving, even if an error happens!
            _bouncer.Release();
        }
    }
}