using System;
using System.Collections;       // For old Non-Generic collections
using System.Collections.Generic; // For modern Generic collections

namespace GenericCollectionsDemo;

public class BoxingUnboxingDemo
{
    public void RunDemo()
    {
        Console.WriteLine("--- 1. Boxing vs Generics ---");

        // ---------------------------------------------------------
        // THE OLD WAY (Dangerous & Slow)
        // ---------------------------------------------------------
        ArrayList oldList = new ArrayList();
        
        // BOXING: Forces the fast 'int' into a slow 'object' box on the Heap
        oldList.Add(10); 
        oldList.Add("Hello"); // Danger! It allows mixing data types

        // UNBOXING: Forces the 'object' back into an 'int'
        int firstNumber = (int)oldList[0]; 
        
        // ERROR: If you uncomment the line below, the program will CRASH!
        // You cannot unbox the string "Hello" into an int.
        // int crashNumber = (int)oldList[1]; 


        // ---------------------------------------------------------
        // THE MODERN WAY (Safe & Fast)
        // ---------------------------------------------------------
        List<int> modernList = new List<int>();
        
        // NO BOXING: It stays a fast 'int' on the Stack.
        modernList.Add(10); 
        
        // modernList.Add("Hello"); // COMPILER ERROR! Type safety protects you.

        int safeNumber = modernList[0]; // NO UNBOXING needed!
        Console.WriteLine($"Modern List is safe! Number is: {safeNumber}");
    }
}