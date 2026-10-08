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

            // // 2. Exception Catching Order
            // var demo2 = new ExceptionOrder();
            // demo2.RunDemo();

            // // 3. The 'throw' Keyword
            // var demo3 = new ThrowDemo();
            // demo3.RunDemo();

            // // 4. Exception Filters (when)
            // var demo4 = new WhenFilter();
            // demo4.RunDemo();

            // 5. Custom Exceptions
            var demo5 = new CustomExceptions();
            demo5.RunDemo();

            Console.WriteLine("\nAll Error Handling concepts tested successfully!");
        }
    }
}