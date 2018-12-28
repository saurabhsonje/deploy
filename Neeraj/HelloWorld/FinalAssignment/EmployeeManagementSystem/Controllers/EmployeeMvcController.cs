using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
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
                client.BaseAddress = new Uri("http://localhost:58641/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/employeeapi/", employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                if (xyz == true)
                {
                    return RedirectToAction("GetEmployees");
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
        public ActionResult GetEmployees()
        {
            var resultList = new List<Employee>();

            var client = new HttpClient();
            var getDataTask = client.GetAsync("http://localhost:58641/api/employeeapi/").
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
        
        public ActionResult Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58641/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("api/employeeapi/"+id).Result;
                bool xyz = response.IsSuccessStatusCode;
                if (xyz == true)
                {
                    return RedirectToAction("GetEmployees");
                }
            }
            catch (Exception exe)
            {
                return View();
            }
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {

            
                Employee employee = null;
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:58641/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("api/employeeapi/" + id).Result;
                    response.EnsureSuccessStatusCode();
                    employee = response.Content.ReadAsAsync<Employee>().Result;
                return View(employee);
                }
                catch (Exception exe)
                {
                
                }
            return View(); 
          
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee employee = null;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58641/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/employeeapi/" + id).Result;
                response.EnsureSuccessStatusCode();
                employee = response.Content.ReadAsAsync<Employee>().Result;
                return View(employee);
            }
            catch (Exception exe)
            {

            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58641/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("api/employeeapi/" + employee.EmpId, employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                return RedirectToAction("GetEmployees");

            }
            catch (Exception exe)
            {
            }
            return View();
        }
    }
}