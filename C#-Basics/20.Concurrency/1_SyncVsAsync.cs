using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyDemo;

public class SyncVsAsync
{
    public void RunSynchronous()
    {
        Console.WriteLine("\n--- 1. Synchronous (Blocking) ---");
        Console.WriteLine("Starting download...");

        // This physically stops the Thread for 2 seconds. The app is completely frozen!
        Thread.Sleep(5000);

        Console.WriteLine("Download finished!");
    }

    public async Task RunAsynchronousAsync()
    {
        Console.WriteLine("\n--- 2. Asynchronous (Non-Blocking) ---");
        Console.WriteLine("Starting download...");

        // The Thread is released to do other work while waiting. The app does NOT freeze.
        await Task.Delay(5000);

        Console.WriteLine("Download finished!");
    }
}