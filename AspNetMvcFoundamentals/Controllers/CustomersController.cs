using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcFoundamentals.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public string Add()
        {
            return "This is customers Add";
        }
    }
}