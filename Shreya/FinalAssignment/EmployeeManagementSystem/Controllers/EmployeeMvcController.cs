using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Text;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeMvcController : Controller
    {
        static HttpClient client1 = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:58641/"),
        };
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
                
                HttpResponseMessage response = client1.PostAsJsonAsync("api/employeeapi/AddEmployee", employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                if (xyz == true)
                {
                    return RedirectToAction("Login");
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

          

            HttpResponseMessage responseMessage = client1.GetAsync("http://localhost:58641/api/employeeapi/").Result;


            if (responseMessage.IsSuccessStatusCode == true)
            {
                List<Employee> employeeList = responseMessage.Content.ReadAsAsync<List<Employee>>().Result;

                return View(employeeList);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            try
            {
                HttpResponseMessage response = client1.PostAsJsonAsync("api/employeeapi/login", employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                if (xyz == true)
                {             
                    var user = employee.EmpUserName;
                    var password = employee.EmpPassword;
                    var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{password}"));
                    client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64String);
                   
                    return RedirectToAction("GetEmployees");
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            catch (Exception exe)
            {
                return View();
            }


        }






        public ActionResult Delete(int id)
        {
            try
            {
             
                HttpResponseMessage response = client1.DeleteAsync("api/employeeapi/" + id).Result;
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
            client1.DefaultRequestHeaders.Authorization = null;

            client1.DefaultRequestHeaders.Accept.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {


            Employee employee = null;
            try
            {
               
             
                HttpResponseMessage response = client1.GetAsync($"api/employeeapi/employee/{id}").Result;
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
            
                HttpResponseMessage response = client1.GetAsync($"api/employeeapi/employee/{id}").Result;
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
           
                HttpResponseMessage response = client1.PutAsJsonAsync("api/employeeapi/" + employee.EmpId, employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                return RedirectToAction("GetEmployees");

            }
            catch (Exception exe)
            {
            }
            return View();
        }



        public ActionResult GetStudio(int id)
        {


            Studio studio = null;
            try
            {
               
                HttpResponseMessage response = client1.GetAsync($"api/employeeapi/studio/{id}").Result;
                //response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    studio = response.Content.ReadAsAsync<Studio>().Result;
                    return View(studio);
                }
                else
                {
                    return RedirectToAction("Index");

                }
                
            }
            catch (Exception exe)
            {

            }
            return View();

        }


    }
}