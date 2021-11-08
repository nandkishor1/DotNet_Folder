//using System;

//namespace ExceptionHandling
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.Write("Enter 1st number: ");
//                int x = int.Parse(Console.ReadLine());
//                Console.Write("Enter th 2nd number: ");
//                int y = int.Parse(Console.ReadLine());
//                int z = x / y;

//                Console.WriteLine("The result is: " + z);
//            }
//            catch(DivideByZeroException ex1)
//            {
//                Console.WriteLine(ex1.Message);
//            }

//            catch (FormatException ex2)
//            {
//                Console.WriteLine("Input must be numeric");
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.WriteLine("End of the Program. ");
//        }
//    }
//}
