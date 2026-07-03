using System;

namespace Concepts.AbstractionDemo;

public class SamsungTv : TvRemote
{
    public override void PressPowerButton()
    {
        Console.WriteLine("User pressed the Power Button.");
        
        // The user only called the power button, but we do the hard work secretly!
        SendInfraredSignal(); 
        
        Console.WriteLine("Samsung TV is now ON!");
    }
}