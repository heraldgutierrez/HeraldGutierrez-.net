using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeraldGutierrez.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Error(string errorCode)
        {
            int code = 0;
            int.TryParse(errorCode, out code);

            switch (code)
            {
                case 403:
                    return View("403");
                case 404:
                    return View("404");
                case 500:
                    return View("500");
                default:
                    return View("GeneralError");
            }
        }
    }
}