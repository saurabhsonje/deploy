using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebMvcApplication.Dao;
using WebMvcApplication.Models;

namespace WebMvcApplication.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDao dao = new EmployeeDao();
               // GET: Employee
        public ActionResult Index()
        {
            var resultList = new List<Employee>();

            var client = new HttpClient();
            var getDataTask = client.GetAsync("http://localhost:59750/api/Employee").
                ContinueWith(response =>
                {
                    var result = response.Result;
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var readResult = result.Content.ReadAsAsync<List<Employee>>();
                        readResult.Wait();
                        resultList = readResult.Result;
                    }
                }
           );
            getDataTask.Wait();

            return View(resultList);
            
        }

        public ActionResult GetByid(int id)
        {
            Employee employee = dao.Index(id);
            return View(employee);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            bool response = dao.Create(employee);
            if (response)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Exist");
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee employee = dao.Index(id);
            return View(employee);
            
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            dao.Update(employee);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            dao.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Exist()
        {
            ViewBag.data = "Employee With That Id Already Exist";
            return View();

        }
    }
}