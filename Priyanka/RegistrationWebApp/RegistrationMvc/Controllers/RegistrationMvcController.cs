using RegistrationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ServiceLayer;

namespace RegistrationMvc.Controllers
{
    public class RegistrationMvcController : Controller
    {
        static string URL = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
        AppDbContext appDBContext = new AppDbContext();
        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(URL)
        };
        // GET: RegistrationMvc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllEmployees()
        {
            List<Register> employeeList = null;
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetAllEmployee/").Result;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employeeList = httpResponseMessage.Content.ReadAsAsync<List<Register>>().Result;
                    return View(employeeList);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Get Information of All Employees...");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }


            return View();
        }
        public ActionResult GetEmployeeByID(int id)
        {
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetEmployeeById/{id}").Result;
            Register employee = null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employee = httpResponseMessage.Content.ReadAsAsync<Register>().Result;
                    return View(employee);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Get Employee...");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);

            }
            return View();
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetEmployeeById/{id}").Result;
            Register employee = null;
            try
            {

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employee = httpResponseMessage.Content.ReadAsAsync<Register>().Result;


                    //return View(employee);
                    return View(employee);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Edit...");
                    return RedirectToAction("GetAllEmployees");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return RedirectToAction("GetAllEmployees");
            }
            //return View();
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Register register)
        {
            HttpResponseMessage httpResponseMessage = client.PutAsJsonAsync($"api/UpdateEmployeeByID/" + register.empId, register).Result;

           

            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllEmployees");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to be Edit...");
                    return View(register);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(register);
            }

        }

        [HttpGet]
        public ActionResult RegisterEmployee()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult RegisterEmployee(Register register)
        {
            HttpResponseMessage httpResponseMessage = client.PostAsJsonAsync($"api/RegisterEmployee", register).Result;

            
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {

                    return RedirectToAction("GetAllEmployees");
                }
                else
                {
                    ModelState.AddModelError("", "Registration is not done...");
                    //return View();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }

            return View();
        }

        public ActionResult DeleteEmployee(int id)
        {
            HttpResponseMessage httpResponseMessage = client.DeleteAsync($"api/DeleteEmployeeById/{id}").Result;
            Register employee = null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    // return RedirectToAction("GetAllEmployees");
                    employee = httpResponseMessage.Content.ReadAsAsync<Register>().Result;


                    //return View(employee);
                    return View(employee);
                }
                else
                {
                    ModelState.AddModelError("", " Employee is not able to delete...");
                    //return View();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("GetAllEmployees");
        }


    }
}