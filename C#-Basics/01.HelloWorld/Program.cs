using System;

namespace HelloWorld
{
    class Pragram
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Hello World");
        string jsonCode = """
            {
                "name" : "Manuth",
                "age": 20
            }
        """;
            Console.WriteLine(jsonCode);
        }
    }
}

