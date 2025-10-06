using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Create a task
        Task task1 = Task.Run(() => PrintNumbers("Task 1"));
        Task task2 = Task.Run(() => PrintNumbers("Task 2"));

        // Wait for all tasks to complete
        await Task.WhenAll(task1, task2);

        Console.WriteLine("All tasks finished (TPL example).");
    }

    static void PrintNumbers(string taskName)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{taskName}: {i}");
            Task.Delay(500).Wait(); // Simulate work
        }
    }
}
