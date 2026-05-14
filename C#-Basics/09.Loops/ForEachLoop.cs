namespace Loops.ForEachLoop;

class ForEachLp
{
    public static void ForEachLoopDemo()
    {
        // We create an Array (A box holding 3 cars)
        string[] cars = { "Audi", "Benz", "BMW" };

        // ==========================================
        // METHOD 1: Using the 'for' loop
        // ==========================================
        Console.WriteLine("--- Using FOR Loop ---");

        // We have to manage the number 'i', check the length, and update it.
        for (int i = 0; i < cars.Length; i++)
        {
            // We use the number 'i' to reach into the box to get the car
            Console.WriteLine("Car " + i + ": " + cars[i]);
        }

        // ==========================================
        // METHOD 2: Using the 'foreach' loop
        // ==========================================
        Console.WriteLine("\n--- Using FOREACH Loop ---");

        // No numbers! Just simple English. 
        foreach (string myCar in cars)
        {
            Console.WriteLine("Car name: " + myCar);
        }
    }
}
