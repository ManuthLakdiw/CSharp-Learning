using System;

namespace AccessModifiers;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== ACCESS MODIFIERS DEMO ===\n");

        // ---------------------------------------------------------
        // 1. Testing Public
        // ---------------------------------------------------------
        PublicExample pub = new PublicExample();
        Console.WriteLine("Public Test: " + pub.PublicMessage);


        // ---------------------------------------------------------
        // 2. Testing Private
        // ---------------------------------------------------------
        PrivateExample priv = new PrivateExample();
        priv.ReadSecret(); // This works because the method is public

        // ERROR: If you remove the // below, the program will crash!
        // You cannot touch a private variable from a stranger class.
        // Console.WriteLine(priv._secretMessage); 


        // ---------------------------------------------------------
        // 3. Testing Protected
        // ---------------------------------------------------------
        ChildClass child = new ChildClass();
        child.ShowFamilyName(); // This works because the child has access to its own method

        // ERROR: If you remove the // below, the program will crash!
        // Program.cs is a Stranger. It is not a child, so it cannot see protected data.
        // Console.WriteLine(child.familyName); 


        // ---------------------------------------------------------
        // 4. Testing Internal
        // ---------------------------------------------------------
        // SUCCESS: Because Program.cs and InternalExample.cs are in the same Project!
        InternalExample intern = new InternalExample();
        Console.WriteLine("Internal Test: " + intern.projectSecret);


        // ---------------------------------------------------------
        // 5. Testing Protected Internal
        // ---------------------------------------------------------
        VipParent vip = new VipParent();
        Console.WriteLine("Protected Internal Test: " + vip.vipMessage);


        Console.WriteLine("\nDemo completed successfully!");
    }
}