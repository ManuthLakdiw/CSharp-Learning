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

    class SwitchExpression
    {
        public static void SwitchDemo()
        {
            Console.WriteLine("Welcome to the Coffee Shop!");
            string coffeeSize = "Medium";

            // ==========================================
            // METHOD 2: The Modern Switch Expression 
            // (Used to calculate the exact price into a variable)
            // ==========================================
            Console.WriteLine("\n--- Processing with Switch Expression ---");

            // We use the switch to instantly grab the correct price number
            double price = coffeeSize switch
            {
                "Small" => 2.00,
                "Medium" => 3.50,
                "Large" => 5.00,
                _ => 0.00 // The underscore '_' is the default backup!
            };

            Console.WriteLine("Your final total is: $" + price);

            Console.ReadLine();
        }
    }


}