using System;

namespace EnumDemo;

// 1. CUSTOM VALUES & UNDERLYING TYPE
// We use ': byte' to save memory. 
// We skip numbers and assign our own exact values!
public enum ErrorCode : byte
{
    None = 0,
    NotFound = 40,
    ServerCrash = 50,
    Unknown = 99
}

public class ErrorHandler
{
    public void ShowErrorDetails(ErrorCode code)
    {
        Console.WriteLine($"Error Name: {code}");

        // 2. CASTING
        // We force the Enum object to reveal its hidden number using (byte)
        byte hiddenNumber = (byte)code;
        
        Console.WriteLine($"Hidden Error Number: {hiddenNumber}");
    }
}