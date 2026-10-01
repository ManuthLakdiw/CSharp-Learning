using System;

namespace GenericCollectionsDemo;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== C# GENERIC COLLECTIONS DEMO ===\n");

        // 1. Boxing vs Generics
        BoxingUnboxingDemo boxingDemo = new BoxingUnboxingDemo();
        boxingDemo.RunDemo();


        // 2. List
        ListDemo listDemo = new ListDemo();
        listDemo.RunDemo();


        // 3. Dictionary
        DictionaryDemo dictDemo = new DictionaryDemo();
        dictDemo.RunDemo();


        // 4. HashSet
        HashSetDemo hashDemo = new HashSetDemo();
        hashDemo.RunDemo();
        

        // 5. Queue and Stack
        QueueStackDemo qsDemo = new QueueStackDemo();
        qsDemo.RunDemo();

        Console.WriteLine("\nAll Collection concepts tested successfully!");
    }
}