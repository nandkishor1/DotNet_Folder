using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProject
{
    class ThreadInConstractor
    {
        static void Test()
        {
            for (int i=1; i<=100; i++)
            {
                Console.WriteLine("Test: " + i);
            }
            static void Main(string[] args)
            {
                Test();
                Console.WriteLine();
            }
        }
    }
}
