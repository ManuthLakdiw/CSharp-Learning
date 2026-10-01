using System;

namespace RecordsDemo;

// We define the main data in the ( ), and open the { } to add more logic.
public record Employee(string Name, string Role)
{
    // You can add extra properties using 'init' to keep it locked!
    public DateTime HiredDate { get; init; } = DateTime.Now;

    // You can add normal methods just like a class!
    public void PrintDetails()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Role: {Role}");
        Console.WriteLine($"Hired On: {HiredDate.ToShortDateString()}");
    }
}