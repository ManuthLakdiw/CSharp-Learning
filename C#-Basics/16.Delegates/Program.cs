using System;

namespace DelegatesDemo
{
    class Program
    {   


        // A matching method for our Custom Delegate
        // Returns void, takes one string.
        static void ShowEmailNotification(string msg)
        {
            Console.WriteLine($"[EMAIL SYSTEM]: {msg}");
        }

        public static void Main(string[] args)
        {
           Console.WriteLine("=== C# DELEGATES DEMO ===\n");

        // ---------------------------------------------------------
        // 1. CUSTOM DELEGATE
        // ---------------------------------------------------------
        Console.WriteLine("--- 1. Custom Delegate ---");
        DownloadManager manager = new();
        
        // We pass the method WITHOUT parentheses (). 
        // We are giving the behavior, not running it yet.
        manager.DownloadFile(ShowEmailNotification);
        }
    }
}