namespace Methods.Examples
{
    public class MethodBasics
    {
        // This is the Main method (the starting point of the program)
        public static void RunBasics()
        {
            Console.WriteLine("=== 1. METHOD BASICS & RETURNS ===\n");

            // 1. Calling a 'void' method (It just does a job, no answer comes back)
            SayHello();

            // 2. Calling a method that returns a value.
            // We MUST create a variable to "catch" the answer that comes out!
            int myAnswer = AddNumbers(10, 5);
            Console.WriteLine("The calculated answer is: " + myAnswer);

            // 3. Reusability! We can call it again easily.
            int anotherAnswer = AddNumbers(100, 250);
            Console.WriteLine("The second answer is: " + anotherAnswer);
            
            Console.WriteLine();
        }

        // ---------------------------------------------------------
        // Example A: A 'void' method with no parameters
        // It does not need ingredients, and gives no answer back.
        // ---------------------------------------------------------
        public static void SayHello()
        {
            Console.WriteLine("Hello! I am a void method. I don't return anything.");
        }

        // ---------------------------------------------------------
        // Example B: A method that takes Parameters and Returns an 'int'
        // Ingredients needed: two integers (a and b)
        // Output: one integer
        // ---------------------------------------------------------
        public static int AddNumbers(int a, int b)
        {
            int total = a + b;
            
            // We MUST use the 'return' keyword because the Return Type is 'int'
            return total; 
        }

        // ---------------------------------------------------------
        // Example C: Using the long .NET Data Type (System.String)
        // This works, but using the C# 'string' is much better!
        // ---------------------------------------------------------
        public static System.String GetRobotName()
        {
            return "Robo-5000";
        }
    }
}