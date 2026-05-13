namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Absolute value: Makes it positive
            Console.WriteLine("Absolute (-10): " + Math.Abs(-10));

            // Rounding: Nearest whole number
            Console.WriteLine("Round (9.99): " + Math.Round(9.99));

            // Ceiling: Rounds UP
            Console.WriteLine("Ceiling (5.1): " + Math.Ceiling(5.1));

            // Floor: Rounds DOWN
            Console.WriteLine("Floor (5.9): " + Math.Floor(5.9));

            // Power: 2 to the power of 3
            Console.WriteLine("Power (2^3): " + Math.Pow(2, 3));

            // Square Root: Root of 64
            Console.WriteLine("Square Root of 64: " + Math.Sqrt(64));
        }
    }
}