using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
    class TestEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1001, "Scoot", "Manager", 50055.0, "Sales", "Banglore");
            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Salary: " + Emp[3]);
            Console.WriteLine("Dname: " + Emp[4]);
            Console.WriteLine("Location: " + Emp[5]);

            Emp["JOB"] = "Developer";
            Emp[3] = 25000.00;

            Console.WriteLine();

            Console.WriteLine("Eno: " + Emp["Eno"]);
            Console.WriteLine("Ename: " + Emp["Ename"]);
            Console.WriteLine("Job: " + Emp["job"]);
            Console.WriteLine("Salary: " + Emp["Salary"]);
            Console.WriteLine("Dname: " + Emp["Dname"]);
            Console.WriteLine("Location: " + Emp["Location"]);
            Console.ReadLine();
        }
    }
}
