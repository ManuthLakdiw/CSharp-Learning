using System;

namespace ConcurrencyDemo
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            Console.WriteLine("=== C# CONCURRENCY ULTIMATE DEMO ===\n");

            // // 1. Sync vs Async
            // var demo1 = new SyncVsAsync();
            // demo1.RunSynchronous();
            // await demo1.RunAsynchronousAsync();

            // // 2. CPU Bound vs I/O Bound
            // var demo2 = new IoVsCpuBound();
            // await demo2.FetchDatabaseDataAsync();
            // await demo2.CalculateHeavyMathAsync();

            // // 3. Advanced Tasks
            // var demo3 = new AdvancedTasks();
            // await demo3.RunWhenAllAsync();
            // await demo3.RunCancellationDemoAsync();

            // // 4. Thread Safety (lock)
            // var demo4 = new ThreadSafetyAndLocks();
            // await demo4.RunSafeCodeAsync();

            // 5. Async Locks (SemaphoreSlim)
            var demo5 = new AsyncLocks();
            await demo5.RunSemaphoreDemoAsync();
        }

    }
}