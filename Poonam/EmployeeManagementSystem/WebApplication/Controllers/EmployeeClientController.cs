using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.HttpClients;
namespace WebApplication.Controllers
{
    public class EmployeeClientController : Controller
    {
        EmployeeClient client = new EmployeeClient();
        // GET: EmployeeClient
        public ActionResult Index()
        {
            
            return View("");

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeInformation employee)
        {
            if (client.Create(employee))
                return View("SuccessAdd");
            //  return RedirectToAction("GetEmployees");
            else
                return RedirectToAction("Create");
        }
        [HttpGet]
        public ActionResult GetEmployees()
        {
            List<EmployeeInformation> employees=client.GetEmployees();
            return View(employees);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }
    }
}