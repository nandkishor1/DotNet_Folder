using System;
namespace StructureProject
{
    struct  MyStructs
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Method in a Structure " +i);

        }
        static void Main()
        {

            MyStructs obj;

            obj.i = 10;
            obj.Display();
            Console.ReadLine();
        }
    }
}