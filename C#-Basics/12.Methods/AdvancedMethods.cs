using System;

namespace Methods.Examples
{
    public class AdvancedMethods
    {
        public static void RunAdvancedFeatures()
        {
            Console.WriteLine("=== 5. ADVANCED FEATURES (REF, OUT, PARAMS, =>) ===\n");

            // ---------------------------------------------------------
            // 1. THE 'ref' KEYWORD
            // ---------------------------------------------------------
            Console.WriteLine("--- 1. The 'ref' Keyword ---");
            int myScore = 10; // MUST have a starting value
            Console.WriteLine("Before ref method: " + myScore); // 10
            
            // We pass the ACTUAL variable, not a copy!
            DoubleMyScore(ref myScore); 
            
            Console.WriteLine("After ref method: " + myScore);  // 20!

            // ---------------------------------------------------------
            // 2. THE 'out' KEYWORD
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 2. The 'out' Keyword ---");
            string secretMessage; // Does NOT need a starting value
            
            // The method promises to fill the empty variable
            GetSecretCode(out secretMessage);
            
            Console.WriteLine("The method pushed this out: " + secretMessage);

            // ---------------------------------------------------------
            // 3. THE 'params' KEYWORD
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 3. The 'params' Keyword ---");
            // Look! We are passing 5 arguments without creating an array!
            int total = AddUnlimitedNumbers(10, 20, 30, 5, 5);
            Console.WriteLine("Total of 5 numbers: " + total);

            // ---------------------------------------------------------
            // 4. EXPRESSION-BODIED METHODS (=>)
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 4. Expression-Bodied Methods (=>) ---");
            
            // Calling our super short 1-line methods
            SayWelcome();
            
            int mathAnswer = Subtract(100, 25);
            Console.WriteLine("100 - 25 = " + mathAnswer);

            Console.WriteLine();
        }

        // =========================================================
        // HELPER METHODS
        // =========================================================

        // REF: Changes the original variable
        public static void DoubleMyScore(ref int score)
        {
            score = score * 2;
        }

        // OUT: Forces the method to assign a value before exiting
        public static void GetSecretCode(out string code)
        {
            code = "AGENT-99"; // If we delete this line, the code will not compile!
        }

        // PARAMS: Packs all arguments into an array named 'numbers' automatically
        public static int AddUnlimitedNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // =========================================================
        // EXPRESSION-BODIED METHODS (=>)
        // =========================================================

        // A simple VOID method using the arrow (No { } needed)
        public static void SayWelcome() => Console.WriteLine("Welcome to the Fast Lane!");

        // A method that RETURNS an int using the arrow (No 'return' keyword needed)
        public static int Subtract(int a, int b) => a - b;
        
        // This is exactly the same as returning a boolean expression!
        public static bool IsAdult(int age) => age >= 18;
    }
}