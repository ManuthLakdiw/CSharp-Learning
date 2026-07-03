using System;

namespace Concepts.AbstractionDemo;

public abstract class TvRemote
{
    // The complex background detail (Hidden from the user)
    protected void SendInfraredSignal()
    {
        Console.WriteLine("[Hidden Process] Sending invisible infrared light signals...");
    }

    // The simple button the user presses
    public abstract void PressPowerButton();
}