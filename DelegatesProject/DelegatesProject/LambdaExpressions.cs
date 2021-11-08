using System;

namespace DelegatesProject
{

    class LambdaExpressions
    {
       
        static void Main()
        {
            GreetingsDelegate obj =  (name) =>
            {
                return "Hello " + name + " a very good Morning!";
            };

            string str = obj.Invoke("Krishna");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
