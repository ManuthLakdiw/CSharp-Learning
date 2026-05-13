namespace Operators.Bitwise
{
    class BitwiseOpr
    {
        public static void BitwiseDemo()
        {
            int a = 5; // Binary: 0101
            int b = 3; // Binary: 0011

            Console.WriteLine("Bitwise Operations on 5 (0101) and 3 (0011)");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Bitwise AND (a & b): " + (a & b)); // Output: 1

            Console.WriteLine("Bitwise OR  (a | b): " + (a | b)); // Output: 7

            Console.WriteLine("Bitwise XOR (a ^ b): " + (a ^ b)); // Output: 6

            Console.WriteLine("Bitwise NOT (~a):    " + (~a));    // Output: -6

            // Shifting
            int c = 3;
            Console.WriteLine("\nShifting the number 3 (0011)");
            Console.WriteLine("Left Shift (c << 1):  " + (c << 1)); // Output: 6 (Multiplied by 2)

            int d = 6;
            Console.WriteLine("Right Shift (d >> 1): " + (d >> 1)); // Output: 3 (Divided by 2)
        }
    }
}