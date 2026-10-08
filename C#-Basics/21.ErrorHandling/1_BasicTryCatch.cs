using System;

namespace ErrorHandlingDemo;

public class BasicTryCatch
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 1. Basic Try-Catch-Finally Demo ---");

        try
        {
            // --- THE DANGER ZONE ---
            Console.WriteLine("Attempting to divide by zero...");
            
            int number = 10;
            int zero = 0;
            int result = number / zero; // CRASH! (Throws DivideByZeroException)

            // This line will NEVER run because the program jumps to the catch block!
            Console.WriteLine("Math was successful!"); 
        }
        catch (Exception ex)
        {
            // --- THE SAFETY NET ---
            // The program safely jumps here instead of crashing the whole app.
            Console.WriteLine($"[ERROR CAUGHT]: {ex.Message}");
        }
        finally
        {
            // --- THE CLEANUP CREW ---
            // This runs 100% of the time, even if there is an error, or if it succeeds.
            Console.WriteLine("Finally block running: Cleaning up resources...");
        }

        Console.WriteLine("Program is still alive and running normally!");
    }
}