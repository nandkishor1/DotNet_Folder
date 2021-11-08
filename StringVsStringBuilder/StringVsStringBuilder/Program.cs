//string are immutable --we can't modify and it takes more time to exection
//StringBuilder is mutable-it can be modify and it has very less   execution time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
{

}

namespace StringVsStringBuilder
{
    class Program
    {
        public static void Main()
        {
            string s = "";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i = 1; i <= 100000; i++)
            {
                s = s + i;

            }
            sw1.Stop();
            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            for (int i = 1; i<=100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time Taken for string: " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time Taken for StringBuilder: " + sw2.ElapsedMilliseconds);
            Console.ReadLine();

            
        }
    }
}
