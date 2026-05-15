namespace Methods.Examples
{
    public class OptionalParameters
    {
        public static void RunParameters()
        {
            Console.WriteLine("=== 2. DEFAULT & OPTIONAL PARAMETERS ===\n");

            // 1. Calling the method with ALL arguments provided
            // It will ignore the defaults and use our data.
            CreateProfile("Manuth", 20, "Sri Lanka");

            // 2. Calling the method with ONLY the required arguments
            // We give 2 arguments, but the method has 3 parameters!
            // It will automatically use the default "Unknown" for the country.
            CreateProfile("Alex", 25);

            // 3. Calling the method with multiple defaults
            OrderCoffee("Large");               // Uses default milk and sugar
            OrderCoffee("Medium", "Almond");    // Uses default sugar

            Console.WriteLine();
        }

        // ---------------------------------------------------------
        // Example A: A method with ONE default parameter
        // RULE: The default parameter (country) MUST be at the end!
        // ---------------------------------------------------------
        public static void CreateProfile(string name, int age, string country = "Unknown")
        {
            Console.WriteLine($"Profile Created: {name}, Age {age}, Country: {country}");
        }

        // ---------------------------------------------------------
        // Example B: A method with MULTIPLE default parameters
        // ALL required parameters first, ALL optional parameters after.
        // ---------------------------------------------------------
        public static void OrderCoffee(string size, string milkType = "Regular", int sugar = 2)
        {
            Console.WriteLine($"Coffee Order: {size} size, {milkType} milk, {sugar} sugars.");
        }

        /* // THIS WILL CAUSE AN ERROR! (Uncomment to see)
        // You cannot put a default parameter before a required parameter.
        
        public static void BadMethod(string name = "John", int age) 
        { 
            // Error!
        }
        */
    }
}