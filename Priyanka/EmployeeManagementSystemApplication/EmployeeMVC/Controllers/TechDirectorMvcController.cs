using EmployeeManagementSystemApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class TechDirectorMvcController : Controller
    {
        static string URL = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];


        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(URL)
        };
        // GET: TechDirectorMvc
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            List<RegistrationModel> employeeList = null;
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetEmployees/").Result;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employeeList = httpResponseMessage.Content.ReadAsAsync<List<RegistrationModel>>().Result;
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
        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            HttpResponseMessage getEmployeeResponse = client.GetAsync($"api/GetEmployeeById/{id}").Result;
            HttpResponseMessage roleListResponse = client.GetAsync("api/GetRoleList").Result;
            HttpResponseMessage studioListResponse = client.GetAsync("api/Studio/GetStudioList").Result;
            IEnumerable<RoleModel> roleList = roleListResponse.Content.ReadAsAsync<IEnumerable<RoleModel>>().Result;
            ViewData["MyRoleList"] = new SelectList(roleList, "RoleName", "RoleName");

            IEnumerable<StudioModel> studioList = studioListResponse.Content.ReadAsAsync<IEnumerable<StudioModel>>().Result;
            ViewData["MyStudioList"] = new SelectList(studioList, "StudioName", "StudioName");
            RegistrationModel employee = null;
            
            try
            {
                
               
                if (getEmployeeResponse.IsSuccessStatusCode)
                {
                    employee = getEmployeeResponse.Content.ReadAsAsync<RegistrationModel>().Result;
                   
                    return View(employee);
                }
                else
                {
                    ModelState.AddModelError("", "Could not retrive employee ");
                    return View();
                }
            }
            catch (Exception exe)
            {
                ModelState.AddModelError("", exe.Message);
                return View();

            }
        }


        [HttpPost]
        public ActionResult EditEmployee(RegistrationModel registrationModel)
        {
            HttpResponseMessage employeeUpdateResponse = client.PutAsJsonAsync("api/TechDirector/EditEmployee/" + registrationModel.EmployeeID, registrationModel).Result;
            HttpResponseMessage roleListResponse = client.GetAsync("api/GetRoleList").Result;
            HttpResponseMessage studioListResponse = client.GetAsync("api/Studio/GetStudioList").Result;
            IEnumerable<RoleModel> roleList = roleListResponse.Content.ReadAsAsync<IEnumerable<RoleModel>>().Result;
            ViewData["MyRoleList"] = new SelectList(roleList, "RoleName", "RoleName");

            IEnumerable<StudioModel> studioList = studioListResponse.Content.ReadAsAsync<IEnumerable<StudioModel>>().Result;
            ViewData["MyStudioList"] = new SelectList(studioList, "StudioName", "StudioName");
            
            try
            {
                
                if (employeeUpdateResponse.IsSuccessStatusCode)
                {
                

                    return RedirectToAction("GetEmployees");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Update employee ");
                    return View();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();

            }
        }
    }
}