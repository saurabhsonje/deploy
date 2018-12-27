﻿using System.Collections.Generic;
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
            
            return View();

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeInformation employee)
        {
           if( client.Create(employee))
            return RedirectToAction("GetEmployees");
           else
                return RedirectToAction("Create");
        }
        [HttpGet]
        public ActionResult GetEmployees()
        {
            List<EmployeeInformation> employees=client.GetEmployees();
            return View(employees);
        }
      
    }
}