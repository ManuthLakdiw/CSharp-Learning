namespace Loops.DoWhileLoop;

class DoWhileLp
{
    public static void DoWhileLoopDemo()
    {
        string secretPin = "1234";
        string userInput;
        int attempts = 0;

        Console.WriteLine("--- Security System Locked ---");

        // We use a DO-WHILE loop because we MUST ask them for the PIN at least once!
        do
        {
            Console.Write("Please enter the 4-digit PIN: ");

            // In a real app, they would type this. We will simulate it.
            // Let's pretend they typed "9999" the first time, and "1234" the second time.
            attempts++;
            if (attempts == 1)
            {
                userInput = "9999";
            }
            else
            {
                userInput = "1234";
            }

            Console.WriteLine(userInput); // Showing what they typed

            if (userInput != secretPin)
            {
                Console.WriteLine("Incorrect PIN. Try again.\n");
            }

        }
        // The Condition: Keep trapping them in the loop WHILE the input is wrong!
        while (userInput != secretPin);

        // This only runs when the loop finally breaks (when userInput == "1234")
        Console.WriteLine("\nAccess Granted. Welcome!");

    }
}