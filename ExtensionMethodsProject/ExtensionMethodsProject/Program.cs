using System;

namespace ExtensionMethodsProject
{
    class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }

        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
        static void Main(string[] args)
        {
            Program oProgram = new Program();
            oProgram.Test1();
            oProgram.Test1();

            Console.ReadLine();
        }
    }
}
