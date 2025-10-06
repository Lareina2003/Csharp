using System;
using System.Threading;
using System.Threading.Tasks;

public sealed class Logger
{
    // Step 1: static variable to hold single instance
    private static Logger instance = null;

    // Step 2: object for locking
    private static readonly object padlock = new object();

    // Step 3: private constructor
    private Logger()
    {
        Console.WriteLine("Logger instance created!");
    }

    // Step 4: Public property (thread-safe Singleton)
    public static Logger Instance
    {
        get
        {
            lock (padlock) // Ensures only one thread at a time can enter
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }

    // Logger method
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message} (HashCode: {this.GetHashCode()})");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Testing with Threads ===");
        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++)
        {
            int index = i;
            threads[i] = new Thread(() =>
            {
                Logger.Instance.Log($"Thread {index} logging...");
            });
            threads[i].Start();
        }

        foreach (var t in threads) t.Join(); // Wait for threads

        Console.WriteLine("\n=== Testing with Tasks ===");
        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++)
        {
            int index = i;
            tasks[i] = Task.Run(() =>
            {
                Logger.Instance.Log($"Task {index} logging...");
            });
        }

        Task.WaitAll(tasks);
    }
}
