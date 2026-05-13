namespace stringVsString;

class Program
{
    static void Main(String[] args)
    {
        // 1. Declare one using the nickname, one using the official name
        string nickname = "hello";
        String official = "HELLO";

        // 2. PROOF: Check if they are the same type
        // This will print 'True' because they are the same
        Console.WriteLine(typeof(string) == typeof(String));

        // 3. Methods: Both have the same tools
        Console.WriteLine(nickname.ToUpper()); // Output: HELLO
        Console.WriteLine(official.ToLower()); // Output: hello

        // 4. Using a static method
        // You can use either, but 'String' is more common here
        bool isEmpty = String.IsNullOrEmpty(nickname);
        Console.WriteLine("Is it empty? " + isEmpty);
    }
}