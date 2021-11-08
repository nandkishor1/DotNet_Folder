//using System;
//using System.Threading;

//namespace ThreadProject
//{
//    class MultithreadingProject
//    {
//        static void Test1()
//        {
//            for (int i = 1; i <= 100; i++)
//            {
//                Console.WriteLine("Test1: " + i);
//            }
//            Console.WriteLine("Thread1 is exiting. ");

//        }

//        static void Test2()
//        {
//            for(int i = 1; i <= 100; i++)
//            {
//                Console.WriteLine("Test2: " + i);
//                if (i == 50)
//                {
//                    Console.WriteLine("Thread2 is going to sleep.");
//                    Thread.Sleep(15000);
//                    Console.WriteLine("Thread2 is woke up.");

//                }
//            }
//            Console.WriteLine("Thread2 is exiting.");
//        }
//        static void Test3()
//        {
//            for(int i=1; i<=100; i++)
//            {
//                Console.WriteLine("Test3: " + i);
//            }
//            Console.WriteLine("Thread3 is exiting.");
//        }

//        static void Main()
//        {
//            Thread T1 = new Thread(Test1);
//            Thread T2 = new Thread(Test2);
//            Thread T3 = new Thread(Test3);
//            T1.Start();
//            T2.Start();
//            T3.Start();

//            Console.WriteLine("Thread main is exiting.");
//        }
//    }
//}


using System;

using System.Threading;

namespace ThreadProject
{
    class ThreadInConstractor
    {
        static void Test()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test: " + i);
            }
            static void Main(string[] args)
            {
                // ThreadStart obj = new ThreadStart(Test);
                ThreadStart obj = Test;
                Thread t = new Thread(obj);
                t.Start();
                Console.ReadLine();
            }
        }
    }
}
