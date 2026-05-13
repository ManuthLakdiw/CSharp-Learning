namespace Operators.Logical
{
    class LogicalOpr
    {
        public static void LogicalDemo()
        {
            int x = 3;

            Console.WriteLine("Our test number is x = 3");
            Console.WriteLine("------------------------");

            // 1. Logical AND (&&)
            // Question: Is 3 less than 5 AND is 3 less than 10? 
            // Answer: Yes and Yes! So the result is True.
            bool andResult = (x < 5 && x < 10);
            Console.WriteLine("Logical AND (x < 5 && x < 10): " + andResult);

            // 2. Logical OR (||)
            // Question: Is 3 less than 5 OR is 3 less than 2?
            // Answer: It is NOT less than 2, BUT it IS less than 5. 
            // Because at least one is True, the result is True.
            bool orResult = (x < 5 || x < 2);
            Console.WriteLine("Logical OR  (x < 5 || x < 2):  " + orResult);

            // 3. Logical NOT (!)
            // We take the exact same AND condition from above, but put a ! in front of it.
            // It takes the True answer and magically flips it to False!
            bool notResult = !(x < 5 && x < 10);
            Console.WriteLine("Logical NOT !(x < 5 && x < 10): " + notResult);

            Console.ReadLine();

        }
    }
}