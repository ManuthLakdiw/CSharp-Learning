using System;

namespace Arrays.Examples
{
    public class ArrayLoops
    {
        public static void RunLoops()
        {
            Console.WriteLine("=== 2. ARRAY LOOPS & LENGTH ===");

            string[] students = [ "John", "Mary", "Peter", "Sarah" ];

            // 1. Finding the Length
            int totalStudents = students.Length;
            Console.WriteLine("Total students in array: " + totalStudents);
            Console.WriteLine("----------------");

            // 2. The 'for' Loop (Gives you index control)
            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Index [" + i + "] = " + students[i]);
            }
            Console.WriteLine("----------------");

            // 3. The 'foreach' Loop (The easy, automatic way)
            Console.WriteLine("Using FOREACH loop:");
            foreach (string studentName in students)
            {
                Console.WriteLine("Student Name: " + studentName);
            }
            Console.WriteLine();
        }
    }
}