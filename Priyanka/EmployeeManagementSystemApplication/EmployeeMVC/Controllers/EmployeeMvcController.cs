using EmployeeManagementSystemApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeMvcController : Controller
    {
        static string URL = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];

        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(URL)
        };
        // GET: EmployeeMvc
        public ActionResult Index()
        {
            return View();
        }
         
        
        public ActionResult GetEmployeeByEmail(string email)
        {
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetEmployeeByEmail/{email}").Result;
            RegistrationModel registrationModel = null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    registrationModel = httpResponseMessage.Content.ReadAsAsync<RegistrationModel>().Result;

                    return View(registrationModel);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to get Employee Details... ");
                }
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View();
        }

        public ActionResult GetStudioByName(int id)
        {
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetStudioByName/{id}").Result;
            StudioModel studioModel = null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    studioModel = httpResponseMessage.Content.ReadAsAsync<StudioModel>().Result;

                    return View(studioModel);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to get Studio Details... ");
                    return RedirectToAction("GetAllEmployees");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return RedirectToAction("GetAllEmployees");
            }
            
        }
    }
}