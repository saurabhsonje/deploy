using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerApplication.Models;

namespace CustomerApplication.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Index()
        {
            var studentList = new List<Customer>{
                      new Customer() { CustomerID = 1, CustomerName = "John", Age = 18 , Contact=9345678901, City="Finance"} ,
                      new Customer() { CustomerID = 2, CustomerName = "Steve",  Age = 21 , Contact=9876543210, City="Development" } ,
                      new Customer() { CustomerID = 3, CustomerName = "Bill",  Age = 25 , Contact=7890123456, City="HR" } ,
                      new Customer() { CustomerID = 4, CustomerName = "Ram" , Age = 20 , Contact=8765904321, City="Finance"} 
                        };
            

            return View(studentList);
        }
    }
}