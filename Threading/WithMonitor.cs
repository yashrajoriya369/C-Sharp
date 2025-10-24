using System;
using System.Threading;

namespace Bill
{
    internal class WithMonitor
    {
        static int balance = 1000;
        static readonly object locker = new object();

        static void Deposit()
        {
            for (int i = 0; i < 1000; i++)
            {
                bool lockTaken = false;
                try
                {
                    // Try to acquire lock with 100ms timeout
                    Monitor.TryEnter(locker, 100, ref lockTaken);

                    if (lockTaken)
                    {
                        balance += 100;
                    }
                    else
                    {
                        Console.WriteLine("Deposit skipped due to timeout.");
                    }
                }
                finally
                {
                    if (lockTaken)
                        Monitor.Exit(locker);
                }
            }
        }

        static void Withdraw()
        {
            for (int i = 0; i < 1000; i++)
            {
                bool lockTaken = false;
                try
                {
                    // Try to acquire lock with 100ms timeout
                    Monitor.TryEnter(locker, 100, ref lockTaken);

                    if (lockTaken)
                    {
                        balance -= 100;
                    }
                    else
                    {
                        Console.WriteLine("Withdraw skipped due to timeout.");
                    }
                }
                finally
                {
                    if (lockTaken)
                        Monitor.Exit(locker);
                }
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(Deposit);
            Thread t2 = new Thread(Withdraw);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Final Balance (With Monitor): " + balance);
        }
    }
}
