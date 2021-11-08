 using System;

namespace IndexerProject
{
    class Employee
    {
        int Eno;
        double Salary;
        string Ename, job, Dname, Location;
        public Employee(int Eno, string Ename, string job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.job = job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eno;

                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
            }
            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Ename = (string)value;
                else if (index == 2)
                    job = (string)value;
                else if (index == 3)
                    Salary = (double)value;
                else if (index == 4)
                    Dname = (string)value;
                else if (index == 5)
                    Location = (string)value;

            }
        }

        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                    return Eno;

                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "JOB")
                    return job;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                return null;
            }


            set
            {
                if (name.ToLower()== "eno")
                    Eno = (int)value;
                else if (name.ToLower() == "ename")
                    Ename = (string)value;
                else if (name.ToLower() == "job")
                    job = (string)value;
                else if (name.ToLower() == "salary")
                    Salary = (double)value;
                else if (name.ToLower() == "dname")
                    Dname = (string)value;
                else if (name.ToLower() == "location")
                    Location = (string)value;

            }
        }
    }
}
