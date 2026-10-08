using System;

namespace ErrorHandlingDemo;

public class ExceptionOrder
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 2. Specific Exceptions Order Demo ---");
        
        int[] numbers = { 10, 20, 30 };

        try
        {
            // Trying to read the 100th item in a list of 3 items!
            Console.WriteLine(numbers[100]); 
        }
        // 1. CATCH SPECIFIC ERRORS FIRST
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("[SPECIFIC ERROR]: You tried to access an item that doesn't exist in the Array!");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("[SPECIFIC ERROR]: You cannot divide by zero!");
        }
        // 2. CATCH GENERIC ERRORS LAST (The Father of all exceptions)
        catch (Exception ex)
        {
            Console.WriteLine($"[GENERIC ERROR]: An unknown error happened: {ex.Message}");
        }
    }
}