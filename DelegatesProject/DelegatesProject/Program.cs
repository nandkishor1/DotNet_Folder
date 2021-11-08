using System;

namespace DelegatesProject
{
    //step 1: Defining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);

    class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad.Invoke(100, 200);
           
            SayDelegate sd = new SayDelegate(Program.SayHello);
            string str = sd.Invoke(" JMS");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
