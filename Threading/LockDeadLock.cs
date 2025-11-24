using System;
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

    
    static void Thread1Work()
    {
        lock (resourceA)
        {
            Console.WriteLine("Thread 1: locked Resource A");
            Thread.Sleep(5000); 

            
            lock (resourceB)
            {
                Console.WriteLine("Thread 1: locked Resource B");
                Console.WriteLine("Thread 1: working with A and B");
            }
        }
    }


    static void Thread2Work()
    {
        lock (resourceB)
        {
            Console.WriteLine("Thread 2: locked Resource B");
            Thread.Sleep(5000); 

            lock (resourceA)
            {
                Console.WriteLine("Thread 2: locked Resource A");
                Console.WriteLine("Thread 2: working with B and A");
            }
        }
    }
}