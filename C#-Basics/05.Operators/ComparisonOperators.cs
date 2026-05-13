namespace Operators.Conparison
{
    class ComparisonOpr
    {
        public static void ComparisonDemo()
        {
            // 1. We create two variables to compare
            int x = 10;
            int y = 5;

            Console.WriteLine("We are comparing x (10) and y (5):");
            Console.WriteLine("---------------------------------");

            // 2. Equal to
            bool isEqual = (x == y);
            Console.WriteLine("x == y (Equal to): " + isEqual); // Outputs False

            // 3. Not equal
            bool isNotEqual = (x != y);
            Console.WriteLine("x != y (Not equal): " + isNotEqual); // Outputs True

            // 4. Greater than
            bool isGreater = (x > y);
            Console.WriteLine("x > y  (Greater than): " + isGreater); // Outputs True

            // 5. Less than
            bool isLess = (x < y);
            Console.WriteLine("x < y  (Less than): " + isLess); // Outputs False

            // 6. Greater than or equal to
            bool isGreaterOrEqual = (x >= y);
            Console.WriteLine("x >= y (Greater or equal): " + isGreaterOrEqual); // Outputs True

            // 7. Less than or equal to
            bool isLessOrEqual = (x <= y);
            Console.WriteLine("x <= y (Less or equal): " + isLessOrEqual); // Outputs False
        }
    }
}