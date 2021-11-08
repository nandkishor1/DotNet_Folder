using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface Interface1
    {
        void Test();
        void Show();
        
    }
    interface Interface2
    {
        void Test();
        void Show();
       
    }
    class InterfaceProject2:Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interface method implemented in child class.");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Declared in interface1 and implemented in class.");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Declared in interface2 and implemented in class.");
        }
        static void Main()
        {
            InterfaceProject2 obj = new InterfaceProject2();
            obj.Test();
            Interface1 i1 = obj;  i1.Show();
            Interface2 i2 = obj;  i2.Show();

            Console.ReadLine();
        }
    }
}
