namespace ConditionalStatement.Switch
{
    class SwitchStatement
    {
        public static void SwitchDemo()
        {
            Console.WriteLine("Welcome to the Coffee Shop!");
            string coffeeSize = "Medium";

            // ==========================================
            // METHOD 1: The Classic Switch Statement
            // ==========================================
            Console.WriteLine("\n--- Processing with Switch Statement ---");

            switch (coffeeSize)
            {
                case "Small":
                    Console.WriteLine("You selected Small. That is $2.00.");
                    break; // Stop and exit!

                case "Medium":
                    Console.WriteLine("You selected Medium. That is $3.50.");
                    break; // Stop and exit!

                case "Large":
                    Console.WriteLine("You selected Large. That is $5.00.");
                    break; // Stop and exit!

                default: // The Backup Plan
                    Console.WriteLine("Error: Unknown size selected.");
                    break;
            }

        }
    }



}