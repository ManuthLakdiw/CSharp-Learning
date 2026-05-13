using static System.Console;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            z = "Hiii";

            WriteLine(z); // error CS0029: Cannot implicitly convert type 'string' to 'int'
        }
    }
}