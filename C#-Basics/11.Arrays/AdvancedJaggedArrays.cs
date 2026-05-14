using System;

namespace Arrays.Examples
{
    public class AdvancedJaggedArrays
    {
        public static void RunAdvancedJagged()
        {
            Console.WriteLine("=== 6. THE JAGGED ARRAY DEEP DIVE ===\n");

            RunStandardJagged();
            Console.WriteLine("--------------------------------------------------");
            RunJaggedOfRectangular();
        }

        // ---------------------------------------------------------
        // A. Standard Jagged Array [][] (Array of Arrays)
        // ---------------------------------------------------------
        private static void RunStandardJagged()
        {
            Console.WriteLine("A. Standard Jagged Array Demo");

            // 1. Declare the main container (3 slots for rows)
            // The second [] is empty because we don't know the inner sizes yet!
            int[][] classroom = new int[3][];

            // 2. CRITICAL STEP: Initialize each row manually
            // If you forget this, you get a NullReferenceException!
            classroom[0] = [ 85, 90, 78 ];       // 3 students
            classroom[1] = [ 92, 88 ];           // 2 students
            classroom[2] = [ 70, 75, 80, 95 ];   // 4 students

            // 3. Printing the jagged structure
            for (int i = 0; i < classroom.Length; i++)
            {
                // We use classroom[i].Length because each row is a DIFFERENT size
                Console.Write($"Class {i} ({classroom[i].Length} students): ");
                foreach (int grade in classroom[i])
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine();
            }
        }

        // ---------------------------------------------------------
        // B. Jagged Array of Rectangular Arrays [][,] 
        // ---------------------------------------------------------
        private static void RunJaggedOfRectangular()
        {
            Console.WriteLine("\nB. Jagged Array of Rectangular Grids [][,]");

            // Imagine a Game with 2 Levels. Every level is a grid of tiles.
            // Level 1: 2x2 grid. Level 2: 3x3 grid.
            int[][,] gameWorlds = new int[2][,];

            // Initialize Level 0 (A 2x2 Rectangular Grid)
            gameWorlds[0] = new int[2, 2] { 
                { 1, 1 }, 
                { 1, 0 } 
            };

            // Initialize Level 1 (A 3x3 Rectangular Grid)
            gameWorlds[1] = new int[3, 3] { 
                { 1, 1, 1 }, 
                { 1, 0, 1 }, 
                { 1, 1, 1 } 
            };

            // Accessing data: [JaggedIndex][RectRow, RectCol]
            int level2Center = gameWorlds[1][1, 1];
            Console.WriteLine("Data at Level 1, Center Tile [1,1]: " + level2Center);

            // Printing the complex structure
            for (int i = 0; i < gameWorlds.Length; i++)
            {
                Console.WriteLine($"\n--- Map of Level {i} ---");
                
                // Outer loop for Rectangular Rows
                for (int r = 0; r < gameWorlds[i].GetLength(0); r++)
                {
                    // Inner loop for Rectangular Columns
                    for (int c = 0; c < gameWorlds[i].GetLength(1); c++)
                    {
                        Console.Write(gameWorlds[i][r, c] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}