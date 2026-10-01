using System;

namespace RecordsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== C# RECORDS DEEP DIVE ===\n");

            // 1. Test Class vs Record Equality
            EqualityDemo equalityDemo = new EqualityDemo();
            equalityDemo.RunDemo();
        }
    }
}
