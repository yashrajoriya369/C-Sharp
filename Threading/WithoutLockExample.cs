using System;
using System.Threading;

// This example demonstrates a race condition. Multiple threads increment a shared counter without synchronization. 

class WithoutLockExample
{
    static int counter = 0;

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter (Without Lock): " + counter);
    }

    static void Increment()
    {
        for (int i = 0; i < 1_00_000; i++)
        {
            // Multiple threads access counter simultaneously
            counter++;
        }
    }
}