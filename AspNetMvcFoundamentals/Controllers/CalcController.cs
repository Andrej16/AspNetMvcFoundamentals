using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcFoundamentals.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc/Mul/5/6
        public ActionResult Index(string operation, int? x, int? y)
        {
            if(x != null && y != null)
                switch (operation)
                {
                    case "Add":
                        ViewBag.Result = x + y;
                        break;
                    case "Mul":
                        ViewBag.Result = x * y;
                        break;
                    case "Div":
                        ViewBag.Result = x / y;
                        break;
                    case "Sub":
                        ViewBag.Result = x - y;
                        break;
                    default:
                        ViewBag.Result = "Unknown operation!";
                        break;
                }
            return View();
        }
    }
}