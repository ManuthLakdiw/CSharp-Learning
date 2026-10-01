using System;

namespace DelegatesDemo;

public class ActionDemo
{
    public void RunDemo()
    {
        // ACTION RULE: Always returns void. It only takes inputs.

        // 1. Traditional Way (Attaching a normal method)
        Action<string> printNormal = PrintMessage;
        
        // 2. Modern Lambda Way (=>)
        // We write the method logic directly on one line!
        // (msg) is the input. Code after '=>' is the logic.
        Action<string> printLambda = (msg) => Console.WriteLine($"[Lambda Action]: {msg}");

        // Executing them
        printNormal("Hello from the normal method!");
        printLambda("Hello from the lambda expression!");
    }

    // Normal helper method
    private void PrintMessage(string msg)
    {
        Console.WriteLine($"[Normal Action]: {msg}");
    }
}