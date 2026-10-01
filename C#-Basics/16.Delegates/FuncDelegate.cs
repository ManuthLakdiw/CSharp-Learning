using System;

namespace DelegatesDemo;

public class FuncDemo
{
    public void RunDemo()
    {
        // FUNC RULE: Always returns a value!
        // Syntax: Func<Input1, Input2, ReturnType> 
        // The LAST data type (int) is ALWAYS the Return Type!

        // Lambda Way: (a, b) are the inputs. 'a * b' is automatically returned.
        Func<int, int, int> multiplyNumbers = (a, b) => a * b;

        // Executing the Func and catching the returned answer
        int result = multiplyNumbers(5, 4);
        
        Console.WriteLine($"Func Result (5 * 4) = {result}");
    }
}