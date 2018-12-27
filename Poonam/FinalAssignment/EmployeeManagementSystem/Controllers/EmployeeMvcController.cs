using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeMvcController : Controller
    {
        // GET: EmployeeMvc
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
        public ActionResult Create(Employee employee)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58019/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/employeeapi/", employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                if(xyz==true)
                {
                    return RedirectToAction("Sucess");
                }
            }
            catch (Exception exe)
            {
                return View();
            }
            return View();
        }
        public ActionResult Sucess()
        {
            return View();
        }
    }
}