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


            // ---------------------------------------------------------
            // 2. ACTION DELEGATE (void)
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 2. Action Delegate ---");
            ActionDemo actionDemo = new ActionDemo();
            actionDemo.RunDemo();


            // ---------------------------------------------------------
            // 3. FUNC DELEGATE (Returns value)
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 3. Func Delegate ---");
            FuncDemo funcDemo = new FuncDemo();
            funcDemo.RunDemo();


            // ---------------------------------------------------------
            // 4. PREDICATE DELEGATE (Returns bool)
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 4. Predicate Delegate ---");
            PredicateDemo predicateDemo = new PredicateDemo();
            predicateDemo.RunDemo();
        }
    }
}