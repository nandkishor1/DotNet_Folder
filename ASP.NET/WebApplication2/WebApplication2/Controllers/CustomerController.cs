using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        //http verb -- Get, Post, Put, Delete
     
        [HttpGet]
        public ActionResult Appoinment()//Action Method
        {
            return View();
        }
        [HttpPost]
        public ActionResult Appoinment(string firstName, string lastName,string phone_Number, string customer_age)//Action Method
        {
            return View();
        }


    }
}
    
