using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; internal set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IList<Student> studentList = new List<Student>() {
                new Student() {StudentID = 1, StudentName = "Nitin", Age = 18 },
                new Student() {StudentID = 1, StudentName = "Moin", Age = 21 },
                new Student() {StudentID = 1, StudentName = "Bill", Age = 20 },
                new Student() {StudentID = 1, StudentName = "vikash", Age = 25 },
                new Student() {StudentID = 1, StudentName = "surj", Age = 15 },

            };

            //var avgAge = studentList.Average(s => s.Age);
            //var count = studentList.Count(s => s.Age>20);

            var oldest = studentList.Max(s => s.Age);

            //IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            //var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            int i = 5;
//            IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
//};
//            IList<Standard> standardList = new List<Standard>() {
//             new Standard(){ StandardID = 1, StandardName="Standard 1"},
//             new Standard(){ StandardID = 2, StandardName="Standard 2"},
//             new Standard(){ StandardID = 3, StandardName="Standard 3"}
//      };


//            var innerJoin = studentList.Join(// outer sequence 
//                        standardList,  // inner sequence 
//                        student => student.StandardID,    // outerKeySelector
//                        standard => standard.StandardID,  // innerKeySelector
//                        (student, standard) => new  // result selector
//                      {
//                            StudentName = student.StudentName,
//                            StandardName = standard.StandardName,
//                            StudentID = student.StudentID
//                        });

//            var groupJoin = standardList.GroupJoin(studentList,
//                standard => standard.StandardID,
//                student => student.StandardID,
//                (standard, student) => new
//                {
//                    Students = student,
//                    StandardFullName = standard
//                });
//            int i = 5;
            //            #region ExampleLINQ
            //            //// Data source
            //            //string[] names = { "Bill", "Steve", "James", "Mohan" };

            //            //// LINQ Query 
            //            //var myLinqQuery = from name in names
            //            //                  where name.Contains('a')
            //            //                  select name;

            //            //var myLinq2 = names.Where(x => x.Contains('a'));

            //            //// Query execution
            //            //foreach (var name in myLinqQuery)
            //            //    Console.Write(name + " ");

            //            //List<string> lstString = new List<string>();
            //            //lstString.Add("Kishor");
            //            //lstString.Add("Rajesh");
            //            //lstString.Add("Levina");
            //            //lstString.Add("Anjana");
            //            //lstString.Add("Sandeep");

            //            //var myList1 = from strName in lstString
            //            //              where strName.Contains('a')
            //            //              select strName;

            //            //var myList2 = lstString.Where(x => x.Contains('a'));

            //            #endregion

            //            #region LINQ1

            //            Student[] studentArray = {
            //            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            //            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            //            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            //            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            //            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            //            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            //            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            //        };

            //            //ofType
            //            IList mixedList = new System.Collections.ArrayList();
            //            mixedList.Add(0);
            //            mixedList.Add("one");
            //            mixedList.Add("two");
            //            mixedList.Add(3);
            //            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
            //            var stringResult = mixedList.OfType<int>();


            //            IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
            //    new Student() { StudentID = 6, StudentName = "Ram" , Age = 19 },
            //    new Student() { StudentID = 7, StudentName = "vivek" , Age = 25 }
            //};
            //            var data = studentList.OrderBy(s => s.Age);
            //            var datadesc = studentList.OrderByDescending(s => s.Age);

            //            var grupBy = studentList.GroupBy(s => s.Age);
            //            //Student[] students = new Student[10];

            //            //int i = 0;

            //            //foreach (Student std in studentArray)
            //            //{
            //            //    if (std.Age > 12 && std.Age < 20)
            //            //    {
            //            //        students[i] = std;
            //            //        i++;
            //            //    }
            //            //}
            //            // Use LINQ to find teenager students
            //            var teenageStudent = studentArray.Where(x => x.Age > 12 && x.Age < 20).ToArray();

            //            // Use LINQ to find first student whose name is Bill 
            //            var searchStudentByName = studentArray.Where(x => x.StudentName == "Bill").ToArray();

            //            // Use LINQ to find student whose StudentID is 5
            //            var searchStudentByID = studentArray.Where(x => x.StudentID == 5).ToArray();

            //            #endregion

            //IList<string> strList1 = new List<string>()
            //{
            //                          "One",
            //                          "Two",
            //                          "Three",
            //                          "Four"
            //};
            //IList<string> strList2 = new List<string>()
            //{
            //                          "One",
            //                          "Two",
            //                          "Five",
            //                          "Six"
            //};
            //var innerJoin = strList1.Join(strList2,
            //                             str1 => str1,
            //                             str2 => str2,
            //                             (str1, str2) => str1);

        }
    }
}
   
