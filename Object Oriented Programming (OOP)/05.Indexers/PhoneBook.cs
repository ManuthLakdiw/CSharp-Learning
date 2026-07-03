using System;
using System.Collections.Generic;

namespace IndexerDemo;

public class PhoneBook
{
    // The storage is a Dictionary!
    private Dictionary<string, int> contacts = new Dictionary<string, int>();

    // THE INDEXER
    // Instead of a number, we use a Name (string) to search!
    public int this[string name]
    {
        get
        {
            if (contacts.ContainsKey(name))
            {
                return contacts[name];
            }
            return 0; // Return 0 if the contact is not found
        }
        set
        {
            // Adds or updates the contact
            contacts[name] = value;
        }
    }
}