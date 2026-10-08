using System;

namespace ErrorHandlingDemo;

public class WhenFilter
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 4. The 'when' Filter Demo ---");

        try
        {
            SimulateDatabaseCrash("Timeout");
        }
        // BOUNCER 1: Only allows "Timeout" errors inside.
        catch (InvalidOperationException ex) when (ex.Message == "Timeout")
        {
            Console.WriteLine("[CAUGHT]: The database is slow. Retrying connection...");
        }
        // BOUNCER 2: Only allows "BadPassword" errors inside.
        catch (InvalidOperationException ex) when (ex.Message == "BadPassword")
        {
            Console.WriteLine("[CAUGHT]: You entered the wrong database password!");
        }
        
        // If the error was "ServerOffline", neither bouncer lets it in. 
        // It will safely pass through (Not Swallowed) and crash or be caught by a higher system!
    }

    private void SimulateDatabaseCrash(string errorType)
    {
        throw new InvalidOperationException(errorType);
    }
}