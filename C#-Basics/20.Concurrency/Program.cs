using System;

namespace ConcurrencyDemo
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            Console.WriteLine("=== C# CONCURRENCY ULTIMATE DEMO ===\n");

            // 1. Sync vs Async
            var demo1 = new SyncVsAsync();
            demo1.RunSynchronous();
            await demo1.RunAsynchronousAsync();

        }

    }
}