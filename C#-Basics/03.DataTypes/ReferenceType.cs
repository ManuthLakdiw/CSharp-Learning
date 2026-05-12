using static System.Console;

namespace DataTypes
{
    class ReferenceDataType
    {
        public static void PredefinedReferenceDataTypeDemo()
        {
            // A. string (The Text Type)
            string myMessage = "Welcome to C# Programming!";
            WriteLine($"string: {myMessage}");


            // B. object (The Master Type)

            // An object can hold an integer
            object secretData = 100;

            // The EXACT SAME object can suddenly hold a string!
            secretData = "Now I am text!";

            // The EXACT SAME object can hold a boolean!
            secretData = true;
            WriteLine($"object: {secretData}");


        }

        public static void UserDefinedReferenceDataTypeDemo()
        {
            // A. class (The Blueprint) -> You can demonstrate it in OOP section

            // B. interface (The Contract) -> You can demonstrate it in OOP section

        }

    }
}