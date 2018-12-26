using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee details
        public ActionResult Index()
        {
            IEnumerable<Employee> employee = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56206/api/");

                var responseTask = client.GetAsync("employeees/");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Employee>>();
                    readTask.Wait();

                    employee = readTask.Result;
                }
                else
                {
                    employee = Enumerable.Empty<Employee>();
                    ModelState.AddModelError(string.Empty, "Server error.Please contact administrator.");
                }
            }
            return View(employee);
        }

        //Create Employee
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(Employee employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56206/api/employees");
                var postTask = client.PostAsJsonAsync<Employee>("employeees", employee);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error . Please contact administrator");

            return View(employee);
        }

        //Edit Employee
        public ActionResult Edit(int id)
        {
            Employee employee = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56206/api/");
                var responseTask = client.GetAsync("employeees?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Employee>();
                    readTask.Wait();

                    employee = readTask.Result;
                }
            }

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56206/api/employeees");

                var putTask = client.PutAsJsonAsync<Employee>("employeees", employee);
                putTask.Wait();

                var result = putTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        //Delete Employee
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56206/api/");

                var deleteTask = client.DeleteAsync("employeees/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
             
            }

            return RedirectToAction("Index");
        }
    }
}