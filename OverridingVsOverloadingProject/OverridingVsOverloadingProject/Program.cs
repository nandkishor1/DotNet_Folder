//using System;

//namespace OverridingVsOverloadingProject
//{
//    class LoadParent
//    {
//        public void Show()
//        {
//            Console.WriteLine("Parent's show method is called. ");

//        }

//        public void Show(int i)
//        {
//            Console.WriteLine("Parent's show method is called. "+i);

//        }
//        public void Test()
//        {
//            Console.WriteLine("Parent's Test method is called.");
//        }

//    }
//    class LoadChild : LoadParent
//    {
//        public void Test(string s)
//        {
//            Console.WriteLine("child's Test method is called."+s);
//        }
//        static void Main()
//        {


//            LoadChild c = new LoadChild();
//            c.Show();
//            c.Test();
//            c.Show(10);
//            c.Test("Nayan");
//        }
//    }
//} 


using System;

namespace OverridingVsOverloadingProject
{
    class LoadParent
    {
        public virtual void Show() // Overridable
        {
            Console.WriteLine("Parent's show method is called. ");

        }

       

        
        public virtual void Test()
        {
            Console.WriteLine("Parent's Test method is called.");
        }

    }
    class LoadChild : LoadParent
    {
        public override void Show() //   Overriding
        {
            Console.WriteLine("Child show method is called. ");

        }

        public override void Test()
        {
            Console.WriteLine("Child Test method is called.");
        }
        static void Main()
        {


            LoadChild c = new LoadChild();
           
            c.Show();
            c.Test();
           
          
        }
    }
}
