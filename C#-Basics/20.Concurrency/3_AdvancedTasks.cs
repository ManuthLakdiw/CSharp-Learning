using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyDemo;

public class AdvancedTasks
{
    public async Task RunWhenAllAsync()
    {
        Console.WriteLine("\n--- Task.WhenAll Demo ---");
        
        // Start all 3 tasks concurrently (at the exact same time)
        Task t1 = Task.Delay(1000); // Takes 1 sec
        Task t2 = Task.Delay(2000); // Takes 2 sec
        Task t3 = Task.Delay(3000); // Takes 3 sec

        Console.WriteLine("Waiting for all 3 tasks to finish...");
        
        // Wait until ALL of them are 100% done. 
        // Total wait time is only 3 seconds, not 6 seconds!
        await Task.WhenAll(t1, t2, t3);
        Console.WriteLine("All tasks completed!");
    }

    public async Task RunCancellationDemoAsync()
    {
        Console.WriteLine("\n--- CancellationToken Demo ---");
        
        // 1. Create the Cancellation Source (The Controller)
        using CancellationTokenSource cts = new CancellationTokenSource();
        
        // 2. Automatically press the "Cancel" button after 2 seconds
        cts.CancelAfter(TimeSpan.FromSeconds(2)); 

        try
        {
            Console.WriteLine("Starting a 5-second download...");
            
            // 3. Pass the Token (Red Flag) into the method
            await DownloadFileAsync(cts.Token); 
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("SUCCESS: The download was safely cancelled midway to save memory!");
        }
    }

    private async Task DownloadFileAsync(CancellationToken token)
    {
        for (int i = 1; i <= 5; i++)
        {
            // Always check if the red flag is raised! If yes, crash and stop immediately.
            token.ThrowIfCancellationRequested();
            
            Console.WriteLine($"Downloading chunk {i}/5...");
            await Task.Delay(1000, token); // Pass token to Delay as well
        }
    }
}