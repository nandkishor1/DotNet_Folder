using System;

namespace Practic_Charp_all_Program
{
    class GradeChecking
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to check Grade:");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Wrong Number");

            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num < 100)
            {
                Console.WriteLine("S Grade");
            }


        }
    }
}