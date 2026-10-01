using System;
using System.Collections.Generic;

namespace GenericCollectionsDemo;

public class ListDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 2. List<T> Demo ---");

        // Create a list that ONLY accepts strings
        List<string> programmingLanguages = new List<string>();

        // Adding items
        programmingLanguages.Add("C#");
        programmingLanguages.Add("Java");
        programmingLanguages.Add("Python");

        // Accessing items by Index (Starts at 0)
        Console.WriteLine($"First language: {programmingLanguages[0]}");

        // Removing an item
        programmingLanguages.Remove("Java");

        // Looping through the list
        Console.WriteLine("Remaining Languages:");
        foreach (string lang in programmingLanguages)
        {
            Console.WriteLine("- " + lang);
        }
    }
}