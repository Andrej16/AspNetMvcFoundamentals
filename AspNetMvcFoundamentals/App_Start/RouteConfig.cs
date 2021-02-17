using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMvcFoundamentals
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new [] { "AspNetMvcFoundamentals.Controllers" });

            //routes.MapRoute(name: "Hello", url: "{controller}/{action}/{name}/{numTimes}");

            routes.MapRoute(
                name: "Calc",
                url: "Calc/{operation}/{x}/{y}/{controller}/{action}",
                defaults: new { controller = "Calc", action = "Index" });

        }
    }
}
