﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeraldGutierrez.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return View("Resume");
        }

        public ActionResult Resume()
        {
            return View();
        }
    }
}