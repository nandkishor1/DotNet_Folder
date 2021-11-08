using System;

namespace MethodHiding
{
    class ParentClass
    {
        public virtual void  Test1()
        {
            Console.WriteLine("Method Test1 from parent class.");
        }

        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class.");
        }
        
    }

    class ChildClass : ParentClass
    {
        public override void  Test1() ///overriding
        {
            Console.WriteLine("Method Test1 from child class");
        }

        public new void Test2() ////hiding /shadowing
        {
            Console.WriteLine("Method Test2 from child class");
        }
        static void Main()
        {
            ChildClass c = new ChildClass(); //c is instance of child class 
            ParentClass p = c; //p is a reference of parent class created by using child's class instance
            p.Test1();//invokes child classes method
            p.Test2();// invokes parent classes method
        }
    }


}
