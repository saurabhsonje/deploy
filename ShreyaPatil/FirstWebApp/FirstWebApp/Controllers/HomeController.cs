using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApp.Models;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var custList = new List<Customer>{new Customer(){ id = 1, name = "Priyanka", city="Nashik",phoneno=7777 } ,
                { new Customer(){ id = 2, name = "Shreya", city="Kolhapur",phoneno=8888} } };
            ViewBag.data = custList;
            return View(custList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}