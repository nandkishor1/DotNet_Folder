using System;

namespace DelegatesProject
{
    public delegate string GreetingsDelegate(string name);

    class AnonymousMethods
    {
        public static string Greetings(string name)
        {
            return "Hello" + name + " a very good Morning!";

        }
        static void Main()
        {
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            {
                string str = obj.Invoke(" Happy Birthday Krishna! ");
                Console.WriteLine(str);

            }
        }
    }
}
