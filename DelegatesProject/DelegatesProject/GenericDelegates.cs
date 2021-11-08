using System;

namespace DelegatesProject
{

    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);

    class GenericDelegates
    {
        
       
       

        static void Main()
        {
            Func<int, float, double, double> obj1 = (x, y, z) => x + y + z;

            double result = obj1.Invoke(100, 1202.01f, 452.258);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x , y , z) => Console.WriteLine(x + y + z);
            obj2.Invoke(100, 102.5f, 544.25);



            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = obj3.Invoke("Hello World");
            Console.WriteLine(status);
            Console.ReadLine();
        }
    }
}
