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

            // 2. Test the 'with' Keyword
            WithKeywordDemo withDemo = new WithKeywordDemo();
            withDemo.RunDemo();

            // 3. Test Advanced Record (Body with Methods)
            Console.WriteLine("\n--- Advanced Record with Body ---");
            Employee emp = new Employee("Manuth Lakdiw", "Software Engineer")
            {
                HiredDate = new DateTime(2025, 1, 15)
            };
            emp.PrintDetails();
        }
    }
}
