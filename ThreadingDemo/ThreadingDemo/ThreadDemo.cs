using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingDemo
{
    class ThreadDemo
    {
        static void Test1()
        {
            Console.WriteLine("Thread1 is stating.");

            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test1: " + i);
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 is Existing");
        }
        static void Test2()
        {
            Console.WriteLine("Thread2 is stating.");

            for (int i = 1; i <= 50; i++) 
            Console.WriteLine("Test2: " + i);
            Console.WriteLine("Thread2 is Existing");

        }
        static void Test3()
        {
            Console.WriteLine("Thread3 is stating.");

            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test3: " + i);
            Console.WriteLine("Thread3 is Existing");

        }

        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            t1.Join();t2.Join();t3.Join();
            Console.WriteLine("Main Thread Existing");
        }
    }
}
