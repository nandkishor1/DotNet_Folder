using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
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
        public ActionResult Index(int id,string name,string password)
        {
            UserRepository oUserRepository = new UserRepository();
            oUserRepository.RegisterUser(id, name, password);
            return View();
        }
    }
}