using System;

namespace IndexerDemo;

public class Team
{
    // The physical storage (Hidden from the outside)
    private string[] players = new string[3];

    // THE INDEXER (The magic door)
    // We use the 'this' keyword to make the object act like an array.
    public string this[int index]
    {
        get 
        {
            // Security Check: Protect the program from crashing!
            if (index >= 0 && index < players.Length)
            {
                return players[index];
            }
            return "Unknown Player";
        }
        set 
        {
            if (index >= 0 && index < players.Length)
            {
                // 'value' is the new data the user provides
                players[index] = value;
            }
            else
            {
                Console.WriteLine("Error: Index is out of bounds!");
            }
        }
    }
}