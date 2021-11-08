using System;

namespace interfaceProject
{
   interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2: ITestInterface1
    {
        void Sub(int a, int b);

    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();

            ITestInterface2 i = obj;
            i.Add(10, 20);
            i.Sub(25, 35);
           // obj.Add(100, 40);
            //obj.Sub(50, 25);
            Console.ReadLine();
        }
    }

    }

