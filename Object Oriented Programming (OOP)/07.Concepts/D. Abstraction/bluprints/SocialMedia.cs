using System;

namespace Concepts.AbstractionDemo;

// 1. THE ABSTRACT CLASS
// You CANNOT create an object directly from this class. It is incomplete!
public abstract class SocialMedia
{
    // You can have normal Properties in an abstract class
    public required string Username { get; set; }

    // 2. CONCRETE METHOD (Finished Method)
    // All social media apps check the internet the exact same way.
    // So, we write the code here once to avoid repeating it.
    public void CheckInternetConnection()
    {
        Console.WriteLine("Checking internet connection... Connected!");
    }

    // 3. ABSTRACT METHOD (Unfinished Rule)
    // Facebook and Twitter log in very differently. 
    // We use 'abstract' to force the Child classes to build their own Login code.
    public abstract void Login();
}