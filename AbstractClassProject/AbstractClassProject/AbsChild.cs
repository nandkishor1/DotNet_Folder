using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    class AbsChild:AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            AbsParent p = c;

            c.Add(100, 25);
            c.Sub(200, 25);
            c.Mul(25, 45);
            c.Div(452, 25);

            //p.Add(100, 25);
            //p.Sub(200, 25);
            //p.Mul(25, 45);
            //p.Div(452, 25);
            Console.ReadLine();
        }
    }
}
