using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        //static void Test()
        //{
        //    for (int i = 1; i <= 100; i++)
        //        Console.WriteLine("Test: " + i);
        //}

        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
                Console.WriteLine("Test: " + i);
        }
        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(Test);
            //Thread t = new Thread(Test);
            //ThreadStart obj = delegate () { Test(); };

            // ThreadStart obj = () => Test();

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);

            Thread t = new Thread(obj);
            t.Start(50);
            Console.ReadLine();
        }
    }
}
