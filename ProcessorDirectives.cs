#define RELEASE

using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode is ON");
#elif RELEASE
        Console.WriteLine("Release mode is ON");
#else
        Console.WriteLine("Neither Debug nor Release defined");
#endif
    }
}
