using System;

namespace EnumDemo;

public enum UserRole
{
    Viewer,
    Editor,
    Admin
}

public class SecuritySystem
{
    public void AssignRole(string userInput)
    {
        // 1. Create an empty box for the result
        UserRole resultBox;

        // 2. TryParse tries to read the string safely.
        // If it works, it puts the answer inside 'resultBox' using 'out'.
        bool isSuccess = Enum.TryParse(userInput, true, out resultBox);

        if (isSuccess)
        {
            Console.WriteLine($"Success! The user is now an {resultBox}.");
        }
        else
        {
            Console.WriteLine($"Error: '{userInput}' is not a valid role!");
        }
    }
}