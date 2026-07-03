using System;

namespace EnumDemo;

// 1. THE FLAGS ATTRIBUTE
// This tells C# that we want to combine these choices.
[Flags]
public enum FileAccess
{
    None = 0,
    Read = 1,       // Power of Two (1)
    Write = 2,      // Power of Two (2)
    Execute = 4,    // Power of Two (4)
    Hidden = 8      // Power of Two (8)
}

public class FileManager
{
    public void CheckPermissions()
    {
        // 2. BITWISE OR (|)
        // We combine Read and Write mathematically (1 + 2 = 3).
        FileAccess myAccess = FileAccess.Read | FileAccess.Write;
        
        Console.WriteLine("My current permissions: " + myAccess);

        // 3. HASFLAG
        // We check if a specific permission is inside the combination
        bool canWrite = myAccess.HasFlag(FileAccess.Write);
        Console.WriteLine("Am I allowed to write? " + canWrite);
    }
}