using System;

namespace Arrays.Examples
{
    public class ArrayLengths
    {
        public static void RunLengthExamples()
        {
            Console.WriteLine("=== 5. LENGTH vs GETLENGTH() ===\n");

            // ---------------------------------------------------------
            // 1. Single Dimensional Array (1D)
            // ---------------------------------------------------------
            int[] oneDim = new int[5]; // 5 boxes

            Console.WriteLine("A. 1D Array [5 boxes]:");
            Console.WriteLine("Total Boxes (.Length): \t\t" + oneDim.Length); // 5

            // .GetLength(1) counts the Columns
            // Console.WriteLine("Columns (.GetLength(1)): \t" + oneDim.GetLength(1)); // 4

            // Note: 1D array වලට .GetLength(0) පාවිච්චි කරන්න පුළුවන් වුණත්, 
            // අපි හැමතිස්සෙම ඒකට .Length තමයි පාවිච්චි කරන්නේ.

            Console.WriteLine("\n--------------------------------------------------");

            // ---------------------------------------------------------
            // 2. Two Dimensional Array (2D) - Perfect Grid
            // ---------------------------------------------------------
            // 3 Rows, 4 Columns (Total 12 boxes)
            int[,] twoDim = new int[3, 4];

            Console.WriteLine("B. 2D Array [3 Rows, 4 Columns]:");
            // .Length counts EVERYTHING (3 x 4)
            Console.WriteLine("Total Boxes (.Length): \t\t" + twoDim.Length);       // 12

            // .GetLength(0) counts the Rows
            Console.WriteLine("Rows (.GetLength(0)): \t\t" + twoDim.GetLength(0));  // 3

            // .GetLength(1) counts the Columns
            Console.WriteLine("Columns (.GetLength(1)): \t" + twoDim.GetLength(1)); // 4

            Console.WriteLine("\n--------------------------------------------------");

            // ---------------------------------------------------------
            // 3. Three Dimensional Array (3D) - Like a Rubik's Cube!
            // ---------------------------------------------------------
            // 2 Pages (Depth), 3 Rows, 4 Columns (Total 24 boxes)
            // Think of this like an Excel workbook with 2 sheets. Each sheet has a 3x4 grid.
            int[,,] threeDim = new int[2, 3, 4];

            Console.WriteLine("C. 3D Array [2 Pages, 3 Rows, 4 Columns]:");
            // .Length counts EVERYTHING (2 x 3 x 4)
            Console.WriteLine("Total Boxes (.Length): \t\t" + threeDim.Length);        // 24

            // Dimension 0: The Depth / Pages
            Console.WriteLine("Pages (.GetLength(0)): \t\t" + threeDim.GetLength(0)); // 2

            // Dimension 1: The Rows
            Console.WriteLine("Rows (.GetLength(1)): \t\t" + threeDim.GetLength(1));  // 3

            // Dimension 2: The Columns
            Console.WriteLine("Columns (.GetLength(2)): \t" + threeDim.GetLength(2));  // 4

        }

        public static void RunOneToFiveDimensions()
        {
            Console.WriteLine("=== THE .GetLength() FUNCTION (1D to 5D) ===\n");

            // 1D Array (1 Level)
            int[] arr1D = new int[4];
            Console.WriteLine("1D Array:");
            Console.WriteLine("Level 0 count: " + arr1D.GetLength(0)); // Output: 4

            // 2D Array (2 Levels)
            int[,] arr2D = new int[3, 4];
            Console.WriteLine("\n2D Array:");
            Console.WriteLine("Level 0 count: " + arr2D.GetLength(0)); // Output: 3
            Console.WriteLine("Level 1 count: " + arr2D.GetLength(1)); // Output: 4

            // 3D Array (3 Levels)
            int[,,] arr3D = new int[2, 3, 4];
            Console.WriteLine("\n3D Array:");
            Console.WriteLine("Level 0 count: " + arr3D.GetLength(0)); // Output: 2
            Console.WriteLine("Level 1 count: " + arr3D.GetLength(1)); // Output: 3
            Console.WriteLine("Level 2 count: " + arr3D.GetLength(2)); // Output: 4

            // 5D Array (5 Levels)
            // Notice there are 4 commas [,,,,] which means 5 dimensions!
            int[,,,,] arr5D = new int[10, 5, 2, 3, 8];
            Console.WriteLine("\n5D Array:");
            Console.WriteLine("Level 0 count: " + arr5D.GetLength(0)); // Output: 10
            Console.WriteLine("Level 4 count (Deepest level): " + arr5D.GetLength(4)); // Output: 8
        }

    }
}