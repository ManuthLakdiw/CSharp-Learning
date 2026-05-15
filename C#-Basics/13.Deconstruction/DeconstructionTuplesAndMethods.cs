using System;

namespace Deconstruction.Examples
{
    public class DeconstructionTuplesAndMethods
    {
        public static void RunDeconstruction()
        {
            Console.WriteLine("=== 4. TUPLE DECONSTRUCTION & DISCARDS ===\n");

            // ---------------------------------------------------------
            // 1. STANDARD DECONSTRUCTION (The long way)
            // ---------------------------------------------------------
            Console.WriteLine("--- 1. Explicit Deconstruction ---");
            (string pName, int pAge, string pCity) = GetPersonData();
            Console.WriteLine($"Explicit -> Name: {pName}, Age: {pAge}, City: {pCity}");

            // ---------------------------------------------------------
            // 2. THE 'VAR' WAY (The clean way)
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 2. Implicit 'var' Deconstruction ---");
            var (name, age, city) = GetPersonData();
            Console.WriteLine($"Implicit -> Name: {name}, Age: {age}, City: {city}");

            // ---------------------------------------------------------
            // 3. USING PRE-EXISTING VARIABLES
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 3. Using Existing Variables ---");
            string existingName;
            int existingAge;
            string existingCity;

            // Notice: No 'var' or types used here!
            (existingName, existingAge, existingCity) = GetPersonData();
            Console.WriteLine($"Existing -> Name: {existingName}");

            // ---------------------------------------------------------
            // 4. THE DISCARD SYMBOL ( _ )
            // We only want the Name. We throw away Age and City.
            // ---------------------------------------------------------
            Console.WriteLine("\n--- 4. Using Discards ( _ ) ---");
            
            var (onlyName, _, _) = GetPersonData();
            
            Console.WriteLine($"Discard -> I only saved the name: {onlyName}");

            Console.WriteLine();
        }

        // =========================================================
        // HELPER METHOD
        // Returns a Tuple with 3 items: Name, Age, City
        // =========================================================
        public static (string, int, string) GetPersonData()
        {
            return ("John Doe", 30, "Colombo");
        }
    }
}