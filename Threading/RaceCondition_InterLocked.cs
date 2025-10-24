using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bill
{
    internal class RaceCondition_InterLocked
    {

        static int counter = 0;
        static int counter2 = 0;
        private static object locker = new object();

        static void Main()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            Thread t3 = new Thread(Increment);
            Thread t4 = new Thread(Increment);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            Console.WriteLine("Final Counter (Without Lock): " + counter);
            Console.WriteLine("Final Counter (With Lock): " + counter2);
        }

        static void Increment()
        {
            for (int i = 0; i < 1_00_000; i++)
            {
                // Multiple threads access counter simultaneously
                counter++;
            }

            for (int j = 0; j < 1_00_000; j++)
            {
                lock (locker)   // Lock is identifer and Locker is object.
                {
                    counter2++;
                }
            }
        }

        //static void Increment1()
        //{
        //    for (int i = 0; i < 1_00_000; i++)
        //    {
        //        lock (locker)   // Lock is identifer and Locker is object.
        //        {
        //            counter2++;
        //        }
        //    }

        //}
    }
}
