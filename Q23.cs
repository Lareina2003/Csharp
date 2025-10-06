using System;
using System.Threading.Tasks;

class Program
{
    // Async method to simulate data fetching
    static async Task<string> FetchDataAsync(string source)
    {
        Console.WriteLine($"Fetching data from {source}...");

        // Simulate network delay (like API call)
        await Task.Delay(2000);

        return $"Data received from {source}";
    }

    // Async Main (C# 7.1 or later supports this)
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start fetching IPO data...\n");

        // Sequential fetching
        string result1 = await FetchDataAsync("Server 1");
        Console.WriteLine(result1);

        string result2 = await FetchDataAsync("Server 2");
        Console.WriteLine(result2);

        Console.WriteLine("\nFetching complete!");
    }
}
