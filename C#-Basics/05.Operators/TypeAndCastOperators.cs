namespace Operators.TypeAndCast;

class TypeAndCastOpr
{
    public static void TypeAndCastDemo()
    {
        // 1. We create a mystery object that contains a string
        object mysteryBox = "Hello Manuth";

        // ==========================================
        // 2. Using 'is' (Asking the question)
        // ==========================================
        if (mysteryBox is string)
        {
            Console.WriteLine("is: Yes! This box contains a string.");
        }

        // ==========================================
        // 3. Using 'as' (The Safe Request)
        // ==========================================
        // "Try to give me this as a string. If it's a number, just give me null."
        string result = mysteryBox as string;

        if (result != null)
        {
            Console.WriteLine("as: Success! I have the text: " + result);
        }
        else
        {
            Console.WriteLine("as: Failed. The box was not a string, but I didn't crash!");
        }

        // ==========================================
        // 4. Using 'typeof' (The Identity Check)
        // ==========================================
        // We get the official .NET info for the 'int' category
        Type info = typeof(int);
        Console.WriteLine("typeof: The official name for 'int' is: " + info.FullName);

    }
}