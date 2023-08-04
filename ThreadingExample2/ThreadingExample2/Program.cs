/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExample2
{
    internal class Program
    {
        private static object lockObject;

        public static class Counter
        {
            public static int CounterValue { get; set; }
        }

        public static void IncrementCounter()
        {
            for (int i = 0; i < 10000; i++)
            {
                lock (lockObject)
                {
                    Counter.CounterValue++;
                }
            }
        }
        static void Main(string[] args)
        {
            lockObject = new object();
            Thread thread1 = new Thread(IncrementCounter);
            Thread thread2 = new Thread(IncrementCounter);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("final Counter Value"+Counter.CounterValue);
            Console.ReadKey();
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExample2
{
    internal class Program
    {
        private static void PrintNumbers(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine($"thread{Thread.CurrentThread.ManagedThreadId} : {i}");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {

            Thread thread1 = new Thread(() => PrintNumbers(10));
            Thread thread2 = new Thread(() => PrintNumbers(12));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }
    }
}
