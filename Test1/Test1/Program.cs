using System;

namespace Test1
{
    class A
    {
        static void Main(string[] args)
        {
            //Single line comment example
            /*Multiline comment example
             * I am just writing for remembering purpose
             * and starting learning C# and .net
             * 
             */
            //int milk = 10;  //Interger  Variable

            /*Data Types in C#:
             
             Integer - int milk; --> 4 bytes
             Long - long Ram; --> 8bytes
             Floating point Number - float that;  --> 4bytes
            Double - double Ram; --> 8bytes
             Character - char a = 'A'; ---> 2 bytes
             Boolean - bool isGreat = true; --> 1 bit
             String - string Ram = "milk"; ---> 2 bytes per character
             
             */
            int a = 5;
            long l = 10000;
            float b = 50.5f;
            double e = 525.25d;
            char c = 'N';
            string d = "JMS";
            bool isGreat = true;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(isGreat);
            // Console.WriteLine(l);
            // Console.WriteLine(e);

            // Type Casting:
            // There are Two types of casting
            // 1. Implicit Casting
            // char to int to long to float to double
            int x = 3;
            double y = x;
            int z = 'y';
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // 2. Explicit Casting

            int p = (int)3.5;
            double q = (double)3.5;
            Console.WriteLine(p);
            Console.WriteLine(q);

            string Ram = Console.ReadLine();
            //Console.WriteLine(Ram);
            //Console.WriteLine("Hello World!");
            //Console.WriteLine ("JMS and the milk is " + milk);
        }
    }
}
