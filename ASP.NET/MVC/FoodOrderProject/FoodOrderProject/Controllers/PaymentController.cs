﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderProject.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Login()
        {
            return View();
        }
    }
}