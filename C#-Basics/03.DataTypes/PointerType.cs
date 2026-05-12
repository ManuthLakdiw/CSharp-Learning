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

    public static void PointerDatTypeWithFixed()
    {
        unsafe
        {
            // 1. We create a normal Reference Type (An Array in the Heap)
            int[] myScores = { 10, 20, 30 };

            // ERROR! You cannot do this: int* badPointer = myScores; 
            // C# will block you because the array might move!

            // 2. We drop the anchor using 'fixed'
            fixed (int* safePointer = myScores)
            {
                // INSIDE THESE BRACKETS, THE ARRAY IS LOCKED TO THE FLOOR.
                // It is 100% safe to use the pointer here.

                // We change the first score from 10 to 99 using the pointer
                *safePointer = 99;

                // We print it to prove it changed
                Console.WriteLine(*safePointer); // Output: 99
            }

            // THE ANCHOR IS NOW LIFTED. The array is allowed to be moved again.
        }
    }
}




