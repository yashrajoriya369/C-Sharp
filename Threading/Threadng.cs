using System;
using System.Threading;

class Threading
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Worker Thread (Numbers): " + i);
            Thread.Sleep(200);
        }
    }

    static void PrintAlphabets()
    {
        for (char c = 'a'; c <= 'j'; c++)
        {
            Console.WriteLine("Worker Thread (Alphabets): " + c);
            Thread.Sleep(300);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);
        t1.Priority = ThreadPriority.AboveNormal;

        Thread t2 = new Thread(PrintAlphabets);
        t2.Priority = ThreadPriority.AboveNormal;

        t1.Start();
        t2.Start();

        for (int i = 1; i <= 5; i++)
        {
            Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(0);
        }

        // Wait for both threads to finish before exiting
        t1.Join();
        t2.Join();

        Console.WriteLine("All threads completed.");
    }
}
