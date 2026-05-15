using System;

namespace Methods.Examples
{
    public class MethodOverloading
    {
        public static void RunOverloading()
        {
            Console.WriteLine("=== 4. METHOD OVERLOADING ===\n");

            // The compiler looks at our arguments and chooses the right method secretly!
            
            // 1. We pass two Integers. It calls Option 1.
            int sum1 = Add(10, 20);
            Console.WriteLine("Sum of two ints: " + sum1);

            // 2. We pass three Integers. It calls Option 2.
            int sum2 = Add(10, 20, 30);
            Console.WriteLine("Sum of three ints: " + sum2);

            // 3. We pass two Doubles (Decimals). It calls Option 3.
            double sum3 = Add(10.5, 20.5);
            Console.WriteLine("Sum of two doubles: " + sum3);

            // 4. We pass a String and an Int. It calls Option 4.
            PrintDetails("Manuth", 20);

            // 5. We pass an Int and a String (Reversed!). It calls Option 5.
            PrintDetails(99, "Alex");

            Console.WriteLine();
        }

        // =========================================================
        // THE OVERLOADED METHODS
        // Notice how they all share the exact same Name!
        // =========================================================

        // Option 1: Two Integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Option 2: Three Integers (Different Count)
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Option 3: Two Doubles (Different Data Type)
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Option 4: String then Int
        public static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"Name first: {name}, Age: {age}");
        }

        // Option 5: Int then String (Different Order)
        public static void PrintDetails(int id, string name)
        {
            Console.WriteLine($"ID first: {id}, Name: {name}");
        }

        /* // THIS WILL CAUSE AN ERROR! 
        // You cannot overload by changing ONLY the return type.
        
        public static double Add(int a, int b) 
        {
            return a + b;
        }
        */
    }
}