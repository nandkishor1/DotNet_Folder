using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleDemo.Controllers
{
    public class HomeController : Controller
    {
        IList<Student> StudentList = new List<Student>()
        {
            new Student(){ StudentID=1, StudentName = "Steve", Age=21 },
            new Student(){ StudentID=2,StudentName ="Bill", Age = 25 },
            new Student(){ StudentID=3,StudentName ="Ram",Age =20 },
            new Student(){ StudentID=4,StudentName ="Vikash", Age = 31 },
            new Student(){ StudentID=5,StudentName ="Raj",Age =22 },

        };
        [HttpGet]
        public ActionResult Index()
        {
            // ViewBag.data = "Storing data using ViewBag";
            // ViewData["demo"] = "Storing data using ViewData";
            // ViewBag.stuList = StudentList;
           //  ViewData["lstStudent"] = StudentList;

            TempData["tmpData"] = "Storing data using TempData";


            Session["UserID"] = "Nandu";

            //  return RedirectToAction("About", "Home");
            return View();

           
        }

        [HttpPost]
        public string  Index(Student objStudent)
        {

            // string str = ViewData["demo"]
            return "StudentID = " + objStudent.StudentID + Environment.NewLine + "StudentName = " + objStudent.StudentName + Environment.NewLine + "Age= " + objStudent.Age;
        }

        public ActionResult About()
        {

            //string str = Convert.ToString(TempData["tmpData"]);

            string str = Convert.ToString(Session["UserID"]);


          return RedirectToAction("Contact", "Home");
           // return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

           // string str = Convert.ToString(TempData["tmpData"]);

            string str = Convert.ToString(Session["UserID"]);


            return View();
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}