using System;
using System.Collections.Generic;

namespace DelegatesDemo;

public class PredicateDemo
{
    public void RunDemo()
    {
        // PREDICATE RULE: Always takes exactly ONE input, and always returns a BOOL.
        // It is used to test a condition (Yes/No questions).

        // Lambda Way: (age) is the input. It returns true if age >= 18.
        Predicate<int> isAdult = (age) => age >= 18;

        Console.WriteLine($"Is 20 an adult? {isAdult(20)}");
        Console.WriteLine($"Is 15 an adult? {isAdult(15)}");

        // ==========================================
        // REAL WORLD USE CASE: Filtering a List
        // ==========================================
        List<int> allAges = new List<int> { 12, 18, 25, 16, 30, 14 };
        
        // FindAll() automatically uses our Predicate to test every single number!
        // It only keeps the numbers that return 'true'.
        List<int> adultsOnly = allAges.FindAll(isAdult);
        
        Console.WriteLine("Adults in the list: " + string.Join(", ", adultsOnly));
    }
}