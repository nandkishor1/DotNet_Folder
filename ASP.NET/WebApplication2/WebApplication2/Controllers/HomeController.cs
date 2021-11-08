using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string CustomerDetails(string firstName, string lastName)
        {

            return firstName + lastName;
        }
        public int GetAge(int age)
        {
            return age;
        }
        public long GetNumber(long number)
        {
            return number;
        }
    }
}