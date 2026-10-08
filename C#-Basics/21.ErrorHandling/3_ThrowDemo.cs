using System;

namespace ErrorHandlingDemo;

public class ThrowDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 3. Throw Keyword Demo ---");

        try
        {
            Console.WriteLine("Trying to register a user with age -5...");
            RegisterUser("Manuth", -5); // This will trigger our manual error!
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"[REGISTRATION FAILED]: {ex.Message}");
        }
    }

    // A method that validates data
    private void RegisterUser(string name, int age)
    {
        if (age < 0)
        {
            // We manually CREATE an exception and THROW it to stop the process!
            throw new ArgumentException("Age cannot be a negative number!");
        }

        Console.WriteLine($"User {name} registered successfully!");
    }
}