namespace Operators.Arithmatic
{
    class ArithmaticOpr
    {
        public static void ArithmaticDemo()
        {
            // 1. Declare the variables
            int result;
            int x = 10, y = 5;

            // Addition
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);

            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);

            // Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);

            // Modulo (Remainder)
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);

            // Increment (Adding 1 to x)
            x++;
            Console.WriteLine("Increment Operator (x++): " + x);

            // Decrement (Subtracting 1 from y)
            y--;
            Console.WriteLine("Decrement Operator (y--): " + y);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}