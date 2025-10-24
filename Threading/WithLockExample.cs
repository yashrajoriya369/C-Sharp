using System;
using System.Threading;

class WithLockExample
{
    static int counter = 0;
    static readonly object locker = new object();

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter (With Lock): " + counter);
    }

    static void Increment()
    {
        for (int i = 0; i < 1_00_000; i++)
        {
            lock (locker)   // Lock is identifer and Locker is object.
            {
                counter++;
            }
        }
    }
}