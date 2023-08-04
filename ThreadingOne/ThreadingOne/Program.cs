/*using System;
namespace ThreadingOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to thread");
            Console.ReadKey();
        }
    }
}
*/
/*using System;
using System.Threading;

namespace ThreadingOne
{
    internal class Program
    {
        public static void MethodOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("MEthod One:");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        public static void MethodTwo()
        {
            for (int i =20; i < 30; i++)
            {
                Console.WriteLine("MEthod Two:");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        public static void MethodThree()
        {
            for (int i = 40; i < 50; i++)
            {
                Console.WriteLine("MEthod Three:");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to thread");
            MethodOne();
            MethodTwo();
            MethodThree();
            Console.ReadKey();
        }
    }
}*/
using System;
using System.Threading;

namespace ThreadingOne
{
    internal class Program
    {
        public static void MethodOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("MEthod One:");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        public static void MethodTwo()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine("MEthod Two:");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        public static void MethodThree()
        {
            for (int i = 40; i < 50; i++)
            {
                Console.WriteLine("MEthod Three:");
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to thread");
            Thread thread1 = new Thread(MethodOne);
            Thread thread2 = new Thread(MethodTwo);
            Thread thread3 = new Thread(MethodThree);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadKey();
        }
    }
}
