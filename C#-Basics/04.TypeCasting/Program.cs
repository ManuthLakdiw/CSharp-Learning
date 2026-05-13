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


            // int myInt = 9;
            // double myDouble = myInt;  // Automatic casting: int to double

            // Console.WriteLine(myInt);      // Outputs 9
            // Console.WriteLine(myDouble);   // Outputs 9


            // double myDouble = 9.78;
            // // We use (int) to FORCE the computer to do it, even though we lose the .78
            // int myInt = (int)myDouble; // Manual casting: double to int

            // Console.WriteLine(myDouble); // Outputs 9.78
            // Console.WriteLine(myInt);    // Outputs 9


            // Convert Class
            string ageText = "25";
            // We translate the text into a real math number!
            int realAge = Convert.ToInt32(ageText);
            WriteLine(realAge);
            WriteLine(realAge.GetType());
        }
    }
}