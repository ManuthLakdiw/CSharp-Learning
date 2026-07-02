using System;

namespace Concepts.PolymorphismDemo;

public class OldPhone
{
    // Notice there is NO 'virtual' keyword here. It is locked!
    public void Ring()
    {
        Console.WriteLine("Ring Ring! (Old bell sound)");
    }
}

public class SmartPhone : OldPhone
{
    // Because the parent is locked, we cannot use 'override'. 
    // We use 'new' to HIDE the parent's method and create our own.
    public new void Ring()
    {
        Console.WriteLine("Playing MP3 Ringtone!");
    }
}