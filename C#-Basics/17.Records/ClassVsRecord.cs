using System;

namespace RecordsDemo;

// 1. A NORMAL CLASS
public class PersonClass 
{ 
    public string Name { get; set; } 
}

// 2. A RECORD (Reference Type, but uses Value Equality)
public record PersonRecord(string Name);

public class EqualityDemo
{
    public void RunDemo()
    {
        Console.WriteLine("--- Class vs Record Equality ---");

        // CLASS TEST (Checks memory address)
        PersonClass class1 = new PersonClass { Name = "Manuth" };
        PersonClass class2 = new PersonClass { Name = "Manuth" };
        
        // Returns FALSE because they live in different memory houses!
        Console.WriteLine($"Class Equality (==): {class1 == class2}"); 

        // RECORD TEST (Checks actual data)
        PersonRecord record1 = new PersonRecord("Manuth");
        PersonRecord record2 = new PersonRecord("Manuth");
        
        // Returns TRUE because the data inside is exactly the same!
        Console.WriteLine($"Record Equality (==): {record1 == record2}"); 
    }
}