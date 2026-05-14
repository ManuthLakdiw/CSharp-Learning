using System;

namespace Arrays.Examples
{
    public class ArrayAdvanced
    {
        public static void RunAdvancedArrays()
        {
            Console.WriteLine("=== 4. ADVANCED: MULTIDIMENSIONAL & JAGGED ARRAYS ===\n");

            RunRectangularArray();
            Console.WriteLine("--------------------------------------------------");
            RunJaggedArray();

            Console.WriteLine();
        }

        // ---------------------------------------------------------
        // Method 1: C# Rectangular Array [,] (Perfect Grid)
        // ---------------------------------------------------------
        private static void RunRectangularArray()
        {
            Console.WriteLine("A. Rectangular Array [,] (Perfect Grid)");
            
            // 3 Rows, 2 Columns (Every row MUST have 2 columns)
            string[,] grid = {
                { "Alice", "Bob" },     // Row 0
                { "Charlie", "David" }, // Row 1
                { "Eve", "Frank" }      // Row 2
            };

            // Using GetLength() for dimensions
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                Console.Write("Row " + r + ": ");
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(grid[r, c] + " \t");
                }
                Console.WriteLine();
            }
        }

        // ---------------------------------------------------------
        // Method 2: C# Jagged Array [][] (Array of Arrays - Like Java!)
        // ---------------------------------------------------------
        private static void RunJaggedArray()
        {
            Console.WriteLine("B. Jagged Array [][] (Array of Arrays)");

            // We create an array that holds 3 'inner' arrays.
            // Notice how each row can have a DIFFERENT number of columns!
            int[][] jaggedArray = new int[3][];
            
            jaggedArray[0] = [ 1, 2 ];           // Row 0 has 2 items
            jaggedArray[1] = [ 3, 4, 5, 6, 7 ];  // Row 1 has 5 items
            jaggedArray[2] = [ 8, 9, 10 ];       // Row 2 has 3 items

            // Because it is an "Array of Arrays", we use normal .Length !
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.Write("Row " + row + ": ");
                
                // We check the length of the specific inner array
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " \t");
                }
                Console.WriteLine();
            }
        }
    }
}