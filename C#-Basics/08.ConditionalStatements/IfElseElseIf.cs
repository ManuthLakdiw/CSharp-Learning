namespace ConditionalStatement.IfElseElseIf
{
    class IfElseElseIfStatement
    {
        public static void IfElseElseIfDemo()
        {
            // 1. We create a variable for the student's score
            int studentScore = 82;

            Console.WriteLine("The student scored: " + studentScore);
            Console.WriteLine("--------------------------------");

            // 2. The Decision Making Block

            // Question 1: Did they get an A?
            if (studentScore >= 90)
            {
                Console.WriteLine("Result: You got an A! Excellent work.");
            }

            // Question 2: If they didn't get an A, did they get a B?
            else if (studentScore >= 75)
            {
                Console.WriteLine("Result: You got a B! Good job.");
            }

            // Question 3: If they didn't get a B, did they get a C?
            else if (studentScore >= 50)
            {
                Console.WriteLine("Result: You got a C! You passed.");
            }

            // The Backup Plan: If ALL the questions above were False...
            else
            {
                Console.WriteLine("Result: You Failed. Please try again.");
            }
        }
    }
}