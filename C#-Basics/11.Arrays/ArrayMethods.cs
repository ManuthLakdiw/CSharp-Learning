using System;

namespace Arrays.Examples
{
    public class ArrayMethods
    {
        public static void RunBuiltInMethods()
        {
            Console.WriteLine("=== 3. BUILT-IN ARRAY METHODS ===");

            int[] scores = [ 45, 10, 99, 2 ];

            Console.WriteLine("Original Scores:");
            PrintArray(scores); // Output: 45 10 99 2

            // 1. SORT: Arrange from lowest to highest
            Array.Sort(scores);
            Console.WriteLine("After Array.Sort():");
            PrintArray(scores); // Output: 2 10 45 99

            // 2. REVERSE: Flip the array backwards
            Array.Reverse(scores);
            Console.WriteLine("After Array.Reverse():");
            PrintArray(scores); // Output: 99 45 10 2

            // 3. CLEAR: Empty the boxes (Reset to 0)
            Array.Clear(scores, 0, scores.Length);
            Console.WriteLine("After Array.Clear():");
            PrintArray(scores); // Output: 0 0 0 0
            
            Console.WriteLine();
        }

        // A private helper method just to print numbers easily
        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}