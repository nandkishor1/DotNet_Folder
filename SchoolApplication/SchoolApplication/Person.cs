//step1: School Application: Student, TeachingStaff, NonTeachingStaff
//Step 2: Identify the attributes of each and every entity.

//Student            TeachingStaff                      NonTeachingStaff

//    -Id              -Id                              -Id
//    -Name            -Name                            -Name
//    -Address         -Address                         -Address
//    -Phone           -Phone                           -Phone
//    -Class           -Designation                     -Designation
//    -Marks           -Salary                          -Salary
//    -Grade           -Qualification                   -Dname
//    -Fees            -Subject                         -MgrId

// Step 3: Identify the common attributes of each entity and put them in  hierarchial order.

// step 4: Define the class representing the entities that are put in hierarchial order 

using System;

namespace SchoolApplication
{
    public class Person
    {
        public int id;
        public string Name, Address, Phone;
    }
    public class Student : Person
    {
        int Class;
        char Grade;
        float Marks, Fees;
    }
    public class Staff : Person
    {
        public double Salary;
        public String Designation;
    }
    public class Teaching : Staff
    {
        string Qualification, Subject;
    }
    public class NonTeaching : Staff
    {
        string Dname;
        int MgrId;

        public static void Main()
        {
            Person p = new Person();
            Console.WriteLine("Running");
            
        }
    }
}
