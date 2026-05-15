namespace Methods.Examples
{
    public class NamedAndTuples
    {
        public static void RunAdvancedMethods()
        {
            Console.WriteLine("=== 3. NAMED ARGUMENTS & TUPLES ===\n");

            // ---------------------------------------------------------
            // 1. NAMED ARGUMENTS
            // ---------------------------------------------------------
            Console.WriteLine("--- Named Arguments ---");
            
            // Standard way (Strict Order: Name, Age, Role)
            CreateUser("Manuth", 20, "Developer");

            // Named Arguments way (Mixed Order - C# knows exactly what to do!)
            CreateUser(role: "Admin", age: 25, name: "Sarah");

            Console.WriteLine("\n--- Multiple Returns (Tuples) ---");

            // ---------------------------------------------------------
            // 2. TUPLES (Choice A: Keeping the bag)
            // ---------------------------------------------------------
            // We catch the entire tuple into one variable called 'result'
            var result = GetHighestScore();
            Console.WriteLine("Tuple kept together:");
            Console.WriteLine($"Player: {result.Item1}, Score: {result.Item2}");

            // ---------------------------------------------------------
            // 3. TUPLES (Choice B: Deconstruction - The GoLang Way!)
            // ---------------------------------------------------------
            // We instantly unpack the bag into two separate variables!
            // Order matters here: string comes first, then int.
            (string topPlayer, int topScore) = GetHighestScore();
            
            Console.WriteLine("\nTuple unpacked (Deconstructed):");
            Console.WriteLine($"The winner is {topPlayer} with {topScore} points!");

            Console.WriteLine();
        }

        // =========================================================
        // HELPER METHODS
        // =========================================================

        // A standard method with 3 parameters
        public static void CreateUser(string name, int age, string role)
        {
            Console.WriteLine($"User Created -> Name: {name}, Age: {age}, Role: {role}");
        }

        // A method that returns TWO values at once using a Tuple!
        // Notice the return type is inside parentheses: (string, int)
        public static (string, int) GetHighestScore()
        {
            string player = "Alex";
            int score = 9500;

            // Returning multiple variables inside parentheses
            return (player, score); 
        }
    }
}