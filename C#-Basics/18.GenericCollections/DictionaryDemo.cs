using System;
using System.Collections.Generic;

namespace GenericCollectionsDemo;

public class DictionaryDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 3. Dictionary<TKey, TValue> Demo ---");

        // Key = int (Student ID), Value = string (Student Name)
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Adding Data
        students.Add(101, "Manuth Lakdiw");
        students.Add(102, "Alex Smith");

        // Reading data instantly using the Key
        Console.WriteLine($"Student 101 is: {students[101]}");

        // Safe searching (To avoid crashes if the key doesn't exist)
        if (students.ContainsKey(105))
        {
            Console.WriteLine(students[105]);
        }
        else
        {
            Console.WriteLine("Student 105 was not found in the database!");
        }
    }
}