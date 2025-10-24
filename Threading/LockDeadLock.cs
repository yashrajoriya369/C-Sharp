﻿using System;
using System.Threading;

class LockDeadlock
{
    static readonly object resourceA = new object();
    static readonly object resourceB = new object();

    static void Main()
    {
        Thread t1 = new Thread(Thread1Work);
        Thread t2 = new Thread(Thread2Work);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Both threads completed.");
    }

    // Thread 1 locks resourceA then tries to lock resourceB
    static void Thread1Work()
    {
        lock (resourceA)
        {
            Console.WriteLine("Thread 1: locked Resource A");
            Thread.Sleep(5000); // simulate work while holding A

            // Now tries to lock B — will block if another thread holds B
            lock (resourceB)
            {
                Console.WriteLine("Thread 1: locked Resource B");
                Console.WriteLine("Thread 1: working with A and B");
            }
            // Releases resourceB automatically
        }
        // Releases resourceA automatically
    }

    // Thread 2 locks resourceB then tries to lock resourceA

    static void Thread2Work()
    {
        lock (resourceB)
        {
            Console.WriteLine("Thread 2: locked Resource B");
            Thread.Sleep(5000); // simulate work while holding B

            // Now tries to lock A — will block if another thread holds A
            lock (resourceA)
            {
                Console.WriteLine("Thread 2: locked Resource A");
                Console.WriteLine("Thread 2: working with B and A");
            }
            // Releases resourceA automatically
        }
        // Releases resourceB automatically
    }
}