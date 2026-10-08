using System;

namespace ErrorHandlingDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== C# ERROR HANDLING ULTIMATE DEMO ===\n");

            // // 1. Basic Try-Catch-Finally
            // var demo1 = new BasicTryCatch();
            // demo1.RunDemo();

            // 2. Exception Catching Order
            var demo2 = new ExceptionOrder();
            demo2.RunDemo();
        }
    }
}