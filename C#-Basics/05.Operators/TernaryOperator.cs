namespace Operators.Ternary;

class TernaryOpr
{
    public static void TernaryDemo()
    {
        int age = 20;
        string userStatus;

        Console.WriteLine("User Age: " + age);
        Console.WriteLine("----------------");

        // ==========================================
        // THE LONG WAY (Standard If-Else)
        // ==========================================
        if (age >= 18)
        {
            userStatus = "Adult";
        }
        else
        {
            userStatus = "Minor";
        }
        Console.WriteLine("Result from standard If-Else: " + userStatus);


        // ==========================================
        // THE SHORT WAY (The Ternary Shortcut)
        // ==========================================
        // The computer asks: Is age >= 18? 
        // If Yes -> return "Adult". If No -> return "Minor".

        string quickStatus = (age >= 18) ? "Adult" : "Minor";

        Console.WriteLine("Result from Ternary Operator: " + quickStatus);

    }
}