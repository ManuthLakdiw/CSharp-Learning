namespace DataTypes;

class PointerDataType
{
    public static void PointerDataTypeDemo()
    {
        int normalNumber = 10; // Safe code

        // We open an unsafe bubble just for the dangerous part
        unsafe
        {
            int* pointer = &normalNumber; // Pointers are allowed in here!
            *pointer = 20;
            Console.WriteLine(normalNumber);
        }

    }

    public static unsafe void PointerDataTypeDemoMath()
    {
        int[] ages = [25, 30, 35];

        fixed (int* ptr = ages)
        {
            // We read the first item (at the starting address)
            Console.WriteLine(*ptr); // Output: 25
            Console.WriteLine((long)ptr); // Output: 5408659160

            // MANUAL MANAGEMENT: We manually jump forward in memory by 1 slot!
            int* nextAddress = ptr + 1;

            // We read the data at the new address
            Console.WriteLine(*nextAddress); // Output: 30
        }
    }
}



