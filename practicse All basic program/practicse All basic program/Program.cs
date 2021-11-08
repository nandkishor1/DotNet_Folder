//Example 5: Bitwise Right shift

using System;

class BitwiseRS
{
    public static void Main()
    {
        int number = 42;

        Console.WriteLine("{0}>>1 = {1}", number, number >> 1);
        Console.WriteLine("{0}>>2 = {1}", number, number >>2);
        Console.WriteLine("{0}>>4 = {1}", number, number >>  4);

    }
}