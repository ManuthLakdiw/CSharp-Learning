using static System.Console;

namespace DataTypes
{
    class ValueDataType
    {
        public static void ValueIntegerTypeDemo()
        {
            //1. byte (8-bit Unsigned)
            byte redColorValue = 255;
            WriteLine($"byte: {redColorValue}");

            //2. sbyte (8-bit Signed)
            sbyte winterTemperature = -15;
            WriteLine($"sbyte: {winterTemperature}");

            //3. short (16-bit Signed)
            short playerAmmo = 12000;
            WriteLine($"short: {playerAmmo}");

            //4. ushort (16-bit Unsigned)
            ushort serverPort = 8080;
            WriteLine($"ushort: {serverPort}");

            //5. int (32-bit Signed)
            int websiteViews = -1500000;
            WriteLine($"int: {websiteViews}");

            //6. uint (32-bit Unsigned)
            uint totalStars = 3500000000;
            WriteLine($"uint: {totalStars}");

            //7. long (64-bit Signed)
            long databaseRowId = 854775807123;
            WriteLine($"long: {databaseRowId}");

            //8. ulong (64-bit Unsigned)
            ulong hashKey = 18446744073709551615ul;
            WriteLine($"ulong: {hashKey}");

        }

        public static void ValueFloatingPointTypeDemo()
        {
            //9. float (32-bit Single-precision)
            float characterSpeed = 12.5f;
            WriteLine($"float: {characterSpeed}");

            //10. double (64-bit Double-precision)
            double mathCalculation = 100.55d;
            WriteLine($"double: {mathCalculation}");

            //11. decimal (128-bit High-precision)
            decimal bankAccountBalance = 150000.50M;
            WriteLine($"decimal: {bankAccountBalance}");

        }

        public static void ValueOtherTypeDemo()
        {
            //12. char (16-bit Character)
            char studentGrade = 'A';
            WriteLine($"char: {studentGrade}");

            //13. bool (Boolean)
            bool isRaining = false;
            WriteLine($"bool: {isRaining}");
        }

    }
}