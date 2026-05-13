namespace Operators.Assignment
{
    class AssigmentOpr
    {
        public static void AssignmentDemo()
        {
            // 1. Basic Assignment
            int x = 10;
            Console.WriteLine("Initial value of x: " + x); // Outputs 10

            // 2. Add and Assign (x += 3)
            x += 3; // Same as x = 10 + 3
            Console.WriteLine("After x += 3, x is: " + x); // Outputs 13

            // 3. Subtract and Assign (x -= 3)
            x -= 3; // Same as x = 13 - 3
            Console.WriteLine("After x -= 3, x is: " + x); // Outputs 10

            // 4. Multiply and Assign (x *= 3)
            x *= 3; // Same as x = 10 * 3
            Console.WriteLine("After x *= 3, x is: " + x); // Outputs 30

            // 5. Divide and Assign (x /= 3)
            x /= 3; // Same as x = 30 / 3
            Console.WriteLine("After x /= 3, x is: " + x); // Outputs 10

            // 6. Modulus and Assign (x %= 3)
            x %= 3; // Same as x = 10 % 3 (Remainder of 10 divided by 3)
            Console.WriteLine("After x %= 3, x is: " + x); // Outputs 1
        }
    }
}