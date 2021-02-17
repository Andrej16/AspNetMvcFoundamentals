using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcFoundamentals.Controllers
{
    public class ControllersAndActionsController : Controller
    {
        // GET: ControllersAndActions
        public ActionResult Index(string id)
        {
            if (id is null)
                return new HttpStatusCodeResult(404, "Данные не предоставоены");
            else
                return Content(id, "text/plain", Encoding.UTF8);
        }
    }
}