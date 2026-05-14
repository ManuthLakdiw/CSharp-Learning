namespace ParameterModifiers.ParamsModifier
{
    class ParamsMdf
    {
        public static void ParamsModifierDemo()
        {
            Console.WriteLine("--- Testing WITHOUT Params ---");

            // 1. We MUST manually create an array object to pass the data.
            int[] myNumbers = new int[] { 10, 20, 30 };
            AddTheHardWay(myNumbers);


            Console.WriteLine("\n--- Testing WITH Params ---");

            // 2. Look how easy this is! No array creation needed.
            AddTheEasyWay(10, 20, 30);

            // We can send as many loose numbers as we want!
            AddTheEasyWay(5, 5, 5, 5, 5, 5);

            // We can even send ZERO numbers. (It creates an empty array).
            AddTheEasyWay();
        }

        // =========================================
        // THE METHODS
        // =========================================

        // Method 1: No params. The user must build the array themselves.
        public static void AddTheHardWay(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers) { total += num; }
            Console.WriteLine("Hard Way Total: " + total);
        }

        // Method 2: Uses params. The C# Compiler builds the array for us!
        public static void AddTheEasyWay(params int[] numbers)
        {
            // Inside the method, we treat it just like a normal array.
            int total = 0;
            foreach (int num in numbers) { total += num; }
            Console.WriteLine("Easy Way Total: " + total);
        }
    }
}
