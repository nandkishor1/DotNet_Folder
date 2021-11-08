using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstname,string lastname,string country,string subject)
        {
            ContactRepository oContactRepository = new ContactRepository();
            oContactRepository.CreateNewContact(firstname, lastname, country, subject);
            return View();
        }
    }
}