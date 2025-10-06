using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create a thread
        Thread thread1 = new Thread(PrintNumbers);
        thread1.Start(); // Start the thread

        // Main thread continues
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Main thread: {i}");
            Thread.Sleep(500); // Sleep for 0.5 sec
        }

        thread1.Join(); // Wait for thread1 to finish
        Console.WriteLine("All threads finished (Thread example).");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Worker thread: {i}");
            Thread.Sleep(700); // Sleep for 0.7 sec
        }
    }
}
