using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadingDemo
{
    class ThreadPerformance
    {
        public static void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i <= 100000000; i++) ;
            Count++;
            Console.WriteLine("IncrementCounter1: " + Count);
        }

        public static void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i <= 100000000; i++) ;
            Count++;
            Console.WriteLine("IncrementCounter2: " + Count);
        }
        static void Main()
        {
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);

            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            s1.Start();
             IncrementCounter1();
             IncrementCounter2();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Time taken to complete the  work in Single Threaded model: " + s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete the  work in multi Threaded model: " + s2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}


using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, reverse = 0;
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is = {0}", reverse);
            Console.ReadLine();
        }
    }
}
