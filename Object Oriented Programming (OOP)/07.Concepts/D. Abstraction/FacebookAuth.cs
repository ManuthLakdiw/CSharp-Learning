using System;

namespace Concepts.AbstractionDemo;

// The colon (:) means FacebookAuth inherits from SocialMedia
public class FacebookAuth : SocialMedia
{
    // We MUST use the 'override' keyword to finish the parent's abstract method.
    // If we do not write this, the computer will give a Red Error!
    public override void Login()
    {
        // The complex algorithm and data processing happens here, 
        // but it is HIDDEN from the normal user!
        Console.WriteLine($"Connecting to Facebook Servers...");
        Console.WriteLine($"Authenticating User: {Username}...");
        Console.WriteLine("Login Successful! Welcome to Facebook.");
    }
}