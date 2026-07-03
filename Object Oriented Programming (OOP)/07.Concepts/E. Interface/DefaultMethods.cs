using System;

namespace Concepts.InterfaceDemo;

public interface ILogger
{
    // 1. Abstract Method (Forced)
    void LogError(string message);

    // 2. DEFAULT METHOD (Optional backup code)
    // It has a body! C# hides this from the normal class object.
    void LogWarning(string message)
    {
        Console.WriteLine($"[DEFAULT WARNING]: {message}");
    }
}

public class ConsoleLogger : ILogger
{
    // We only HAVE to implement the abstract method
    public void LogError(string message)
    {
        Console.WriteLine($"[ERROR]: {message}");
    }
    // We ignored LogWarning(), so it will use the default one!
    
}