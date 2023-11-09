using AspNetMvcFoundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcFoundamentals.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            ViewBag.Products = new ProductCollection().products;
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            ViewBag.Products = new ProductCollection().products;
            return View("Index", id);
        }
        public ActionResult FindById(int? id)
        {
            var data = new ProductCollection().products;
            if (id == null)
                return null;
            return PartialView(data.Where(e => e.ProductId == id));
        }
        public ActionResult FindByName(string name)
        {
            var data = new ProductCollection().products;
            if (string.IsNullOrEmpty(name))
                return null;
            // выполняем выборку по свойству Customer если значение id не пустое и не равное "All"
            return PartialView(data.Where(e => e.Name == name));
        }
    }
}