using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HeraldGutierrez
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Resume",
                url: "Resume",
                defaults: new { controller = "Default", action = "Resume", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DailyProgrammer",
                url: "DailyProgrammer/{action}/{id}",
                defaults: new { controller = "DailyProgrammer", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Error", // Route name
                "Error/{errorCode}", // URL with parameters
                new { controller = "Error", action = "Error", errorCode = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
