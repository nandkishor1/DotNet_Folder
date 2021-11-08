using System;


namespace ExtensionMethodsProject
{
     class TestExtMethods
    {
        static void Main()
        {
            Program oProgram = new Program();
            oProgram.Test1();
            oProgram.Test2();
            oProgram.Test3(10);

            int i = 4;
            long result = i.Factorial();
            Console.WriteLine("Factorial of {0} is: {1}", i, result);

            string str = "hEllo hoW Are yoU";
            str = str.ToProper();
            Console.WriteLine(str);

            Console.ReadLine();
        }
        
    }
}