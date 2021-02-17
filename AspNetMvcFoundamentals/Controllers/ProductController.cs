using AspNetMvcFoundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcFoundamentals.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            ProductCollection productCollection = new ProductCollection();
            return View(productCollection.products);
        }
        public string Details()
        {
            return "This is details action!";
        }

    }
}