using System;
using System.Collections.Generic;

namespace GenericCollectionsDemo;

public class QueueStackDemo
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 5. Queue and Stack Demo ---");

        // ---------------------------------------------------------
        // QUEUE: First-In, First-Out (FIFO)
        // ---------------------------------------------------------
        Console.WriteLine("[Queue Test]");
        Queue<string> printerQueue = new Queue<string>();
        
        printerQueue.Enqueue("Document_1.pdf"); // Goes first
        printerQueue.Enqueue("Photo_2.png");    // Goes second

        // Dequeue removes the FIRST item that went in
        Console.WriteLine($"Printing: {printerQueue.Dequeue()}"); 


        // ---------------------------------------------------------
        // STACK: Last-In, First-Out (LIFO)
        // ---------------------------------------------------------
        Console.WriteLine("\n[Stack Test]");
        Stack<string> browserHistory = new Stack<string>();
        
        browserHistory.Push("google.com");
        browserHistory.Push("github.com"); // Goes on TOP

        // Pop removes the LAST item that went in (The Top item)
        Console.WriteLine($"Going back to: {browserHistory.Pop()}");
    }
}