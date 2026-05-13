using static System.Console;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // int z;
            // z = "Hiii";

            // WriteLine(z); // error CS0029: Cannot implicitly convert type 'string' to 'int'


            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9
        }
    }
}