using System;

namespace EnumDemo;

// 1. THE BASIC ENUM
// This creates a strict list of choices for our order status.
public enum OrderStatus
{
    Pending,    // Hidden value: 0
    Processing, // Hidden value: 1
    Shipped,    // Hidden value: 2
    Delivered   // Hidden value: 3
}

public class Order
{
    public string CustomerName { get; set; }
    public OrderStatus Status { get; set; }

    // Using the Enum in a Switch statement
    public void PrintOrderUpdate()
    {
        Console.Write($"Order for {CustomerName}: ");

        switch (Status)
        {
            case OrderStatus.Pending:
                Console.WriteLine("We are waiting to start your order.");
                break;
            case OrderStatus.Processing:
                Console.WriteLine("We are boxing your items right now!");
                break;
            case OrderStatus.Shipped:
                Console.WriteLine("Your package is on the way!");
                break;
            case OrderStatus.Delivered:
                Console.WriteLine("Package delivered safely!");
                break;
            default:
                Console.WriteLine("Unknown order status.");
                break;
        }
    }
}