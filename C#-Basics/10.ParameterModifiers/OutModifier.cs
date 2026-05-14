namespace ParameterModifiers.OutModifier
{
    class OutMdf
    {
        public static void OutModifierDemo()
        {
            int num1 = 10;
            int num2 = 5;

            // 1. We create an EMPTY box for the second answer

            Console.WriteLine("--- Testing Multiple Returns with 'out' ---");

            // 2. We call the method. 
            // - The standard 'return' value goes into 'additionResult'
            // - The extra answer fills up our empty 'multiplicationResult' box!

            int additionResult = CalculateBoth(num1, num2, out int multiplicationResult);

            // 3. Look! We got two different answers back from ONE method!
            Console.WriteLine("The Addition answer is: " + additionResult);
            Console.WriteLine("The Multiplication answer is: " + multiplicationResult);

            Console.ReadLine();
        }

        // =========================================
        // THE METHOD
        // It has a standard return (int), AND an 'out' parameter.
        // =========================================
        public static int CalculateBoth(int a, int b, out int multiplyBox)
        {
            // The strict rule: We MUST fill the 'out' box before we leave!
            // We don't have to do math, but here we will:
            multiplyBox = a * b;

            // Then we return the standard answer
            return a + b;
        }
    }
}
