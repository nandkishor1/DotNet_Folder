using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class FirstTestingAppController : Controller
    {
        // GET: FirstTestingApp
        public ActionResult Index()
        {
            return View();
        }
        public string TestMethod(string name)
        {
            return name;



        }
    }
}
