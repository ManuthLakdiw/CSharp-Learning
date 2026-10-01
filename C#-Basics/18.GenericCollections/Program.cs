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
    }
}