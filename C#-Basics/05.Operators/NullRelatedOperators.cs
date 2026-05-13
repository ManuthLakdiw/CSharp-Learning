namespace Operators.NullRelated
{
    class NullRelatedOpr
    {
        public static void NullRelatedDemo()
        {
            // Let's pretend a user just signed up, but didn't enter a name
            string userName = null;

            // ==========================================
            // 1. Using the ?? Operator (The Backup Plan)
            // ==========================================
            // The computer checks userName. It is null! So it uses "Guest" instead.
            string displayTitle = userName ?? "Guest";

            Console.WriteLine("Welcome, " + displayTitle + "!"); // Outputs: Welcome, Guest!


            // ==========================================
            // 2. Using the ?. Operator (The Safe Checker)
            // ==========================================
            // If we typed: userName.Length -> CRASH!
            // By using userName?.Length -> It safely returns null instead of crashing.

            int? nameLength = userName?.Length;

            Console.WriteLine("Length of name: " + nameLength); // Outputs nothing (null) safely.


            // ==========================================
            // 3. Using BOTH together! (Advanced Master Combo)
            // ==========================================
            // "Safely get the length. If it's null, use the backup number 0."
            int finalLength = userName?.Length ?? 0;

            Console.WriteLine("Safe Length Number: " + finalLength); // Outputs: 0
        }
    }
}