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

    class SwitchAdvanced()
    {
        public static void SwitchDemo()
        {
            int score = 85;
            bool hasCheated = false;

            Console.WriteLine("--- Advanced Switch Statement ---");

            switch (score)
            {
                // 1. Using the 'when' keyword for a boolean check!
                // It only runs this case if the score is 100 AND they didn't cheat.
                case 100 when hasCheated == false:
                    Console.WriteLine("Perfect Score! You win a gold medal.");
                    break;

                // 2. Using Relational Pattern Matching ( > and < )
                case >= 80:
                    Console.WriteLine("Grade: A");
                    // 3. Multi-line code inside a case
                    Console.WriteLine("Great job, you are doing very well.");
                    int extraPoints = 5;
                    Console.WriteLine("We added " + extraPoints + " bonus points!");
                    break;

                // 4. Stacking cases (checking multiple values at once)
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("You got a 0, 1, or 2. You completely failed.");
                    break;

                // 5. The Default Case
                default:
                    Console.WriteLine("Standard passing grade.");
                    break;
            }

            Console.WriteLine("\n--- Advanced Switch Expression ---");

            // Using "or", greater-than symbols, and the mandatory "_" default!
            string gradeCategory = score switch
            {
                100 => "Perfect",
                >= 80 => "High Distinction",
                50 or 51 or 52 => "Barely Passed", // Multiple values
                < 50 => "Failed",
                _ => "Average" // Mandatory default backup
            };

            Console.WriteLine("Your Category is: " + gradeCategory);
        }
    }
}