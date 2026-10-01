using System;
using System.Collections.Generic;

namespace GenericCollectionsDemo;

public class HashSetDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 4. HashSet<T> Demo ---");

        HashSet<string> uniqueEmails = new HashSet<string>();

        // Adding unique emails
        uniqueEmails.Add("admin@codecraft.lk");
        uniqueEmails.Add("hello@memoria.app");

        // Trying to add a DUPLICATE email
        bool isAdded = uniqueEmails.Add("admin@codecraft.lk");

        Console.WriteLine($"Was duplicate added? {isAdded}"); // Output: False
        Console.WriteLine($"Total unique emails: {uniqueEmails.Count}"); // Output: 2

        foreach (string email in uniqueEmails)
        {
            Console.WriteLine("- " + email);
        }
    }
}