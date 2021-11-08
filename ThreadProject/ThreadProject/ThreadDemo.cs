using System;
using System.Threading;
namespace ThreadProject
{
    class ThreadDemo
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2: " + i);
                if (i == 50)
                {
                    Console.WriteLine("Main Thread is going to sleep.");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main Thread woke up.");
                }
            }
        }
                static void Test3()
                {
                    for(int i = 1; i <= 100; i++)
                    {
                        Console.WriteLine("Test3: " + i);
                    }
                
            }
        
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
        }
    }
}
