using FoodOrderProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderProject.Controllers
{
    public class OrderFoodController : Controller
    {
        // GET: OrderFood
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name,string pwd,string ID)
        {
            UserRepository oUserRepository = new UserRepository();
            oUserRepository.RegisterUser(name, pwd,ID);
            return View();
        }
    }
}