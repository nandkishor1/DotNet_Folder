using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class FinallyDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter th 2nd number: ");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    return;

                }
                int z = x / y;

                Console.WriteLine("The result is: " + z);
            }

            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed. ");
            }
            Console.WriteLine("End of the Program. ");
        }
    }

}
