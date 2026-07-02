using System;

namespace AccessModifiers;

public class PrivateExample
{
    // 2. PRIVATE: The Secret Safe
    // Only code written inside this exact class can see this variable.
    private string _secretMessage = "This is a secret. Do not tell anyone.";

    // To let outsiders read the secret, we must create a public method inside the same class.
    public void ReadSecret()
    {
        // SUCCESS: We are inside the same { } braces, so we have the key to read it!
        Console.WriteLine("Reading inside the class: " + _secretMessage);
    }
}