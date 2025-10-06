using System;

public sealed class Singleton
{
    // Step 1: Private static instance (lazy initialization)
    private static Singleton instance = null;

    // Step 2: Lock object for thread-safety
    private static readonly object padlock = new object();

    // Step 3: Private constructor (no outside new())
    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created!");
    }

    // Step 4: Public static property to access instance
    public static Singleton Instance
    {
        get
        {
            lock (padlock)   // thread safety
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    // Example method
    public void ShowMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        // Try to create multiple instances
        Singleton s1 = Singleton.Instance;
        s1.ShowMessage("Hello from first object");

        Singleton s2 = Singleton.Instance;
        s2.ShowMessage("Hello from second object");

        // Check if both are same instance
        Console.WriteLine(Object.ReferenceEquals(s1, s2)
                          ? "Both are same instance"
                          : "Different instances");
    }
}
