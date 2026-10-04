using System;

namespace LinqDemo;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== C# LINQ ULTIMATE DEMO ===\n");

        SyntaxDemo demo1 = new SyntaxDemo();
        demo1.Run();


        FilterAndSelectDemo demo2 = new FilterAndSelectDemo();
        demo2.Run();

        SortAndPaginateDemo demo3 = new SortAndPaginateDemo();
        demo3.Run();

        MathAndConditionsDemo demo4 = new MathAndConditionsDemo();
        demo4.Run();

        SingleElementsDemo demo5 = new SingleElementsDemo();
        demo5.Run();

        GroupAndChainDemo demo6 = new GroupAndChainDemo();
        demo6.Run();

        Console.WriteLine("\nAll LINQ concepts tested successfully!");
    }
}