using System;

namespace Methods.Examples
{
    public class ExpressionBodiedDeepDive
    {
        public static void RunExpressionExamples()
        {
            Console.WriteLine("=== 5.1 EXPRESSION-BODIED METHODS DEEP DIVE ===\n");

            // 1. Calling a void expression method
            PrintGreeting();

            // 2. Calling a return expression method
            int total = Multiply(5, 4);
            Console.WriteLine("5 * 4 = " + total);

            // 3. Proving both ways work!
            Console.WriteLine("Classic Method says: " + GetFavoriteColorClassic());
            Console.WriteLine("Modern Method says:  " + GetFavoriteColorModern());

            Console.WriteLine();
        }

        // =========================================================
        // EXAMPLES: VOID VS RETURN
        // =========================================================

        // Example A: A VOID method. It just performs an action.
        public static void PrintGreeting() => Console.WriteLine("Hello from a 1-line method!");

        // Example B: A RETURN method. It calculates and gives back an int.
        // Notice: We DO NOT write the word 'return'! The => does it automatically.
        public static int Multiply(int a, int b) => a * b;

        // =========================================================
        // COMPARISON: CLASSIC VS MODERN (Both are 100% Correct)
        // =========================================================

        // The Classic Way (Takes 4 lines)
        public static string GetFavoriteColorClassic()
        {
            return "Blue";
        }

        // The Modern Way (Takes 1 line)
        public static string GetFavoriteColorModern() => "Blue";

        // =========================================================
        // THE RULE: WHEN YOU CANNOT USE =>
        // =========================================================
        
        /* // THIS IS AN ERROR! You cannot use => for multiple lines or loops!
        public static void CountToTen() => 
            for(int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
        */

        // If you need more than 1 line, you MUST use Classic { }
        public static void CountToThree()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
        }
    }
}