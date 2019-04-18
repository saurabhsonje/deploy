using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Employee.Data;
using EmployeeManagementSystemApplication.Models;

namespace EmployeeMVC.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class RegistrationMvcController : Controller
    {
        static string URL = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
        //AppDBContext appDBContext = new AppDBContext();

        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(URL)
        };

        // GET: RegistrationMvc
        public ActionResult Index()
        {
            return View();
        }

        //GET
        
        public ActionResult GetAllEmployees()
        {
            List<RegistrationModel> employeeList = null;
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/Registration/").Result;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employeeList = httpResponseMessage.Content.ReadAsAsync<List<RegistrationModel>>().Result;
                    return View(employeeList);
                }
                else
                {
                    ModelState.AddModelError("","Unable to Get Information of All Employees...");
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
            RegistrationModel employee = null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employee = httpResponseMessage.Content.ReadAsAsync<RegistrationModel>().Result;
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
            RegistrationModel employee = null;
            HttpResponseMessage roleListResponse = client.GetAsync("api/GetRoleList").Result;
            HttpResponseMessage studioListResponse = client.GetAsync("api/Studio/GetStudioList").Result;
            IEnumerable<RoleModel> roleList = roleListResponse.Content.ReadAsAsync<IEnumerable<RoleModel>>().Result;
            ViewData["MyRoleList"] = new SelectList(roleList, "RoleName", "RoleName");

            IEnumerable<StudioModel> studioList = studioListResponse.Content.ReadAsAsync<IEnumerable<StudioModel>>().Result;
            ViewData["MyStudioList"] = new SelectList(studioList, "StudioName", "StudioName");
            try
            {
               
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    employee = httpResponseMessage.Content.ReadAsAsync<RegistrationModel>().Result;
              
                   
                     //return View(employee);
                    return View(employee);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Edit...");
                    return RedirectToAction("GetAllEmployees");
                }
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return RedirectToAction("GetAllEmployees");
            }
            //return View();
        }

        [HttpPost]
        public ActionResult UpdateEmployee(RegistrationModel registrationModel)
        {
            HttpResponseMessage httpResponseMessage = client.PutAsJsonAsync("api/UpdateEmployeeByID/" + registrationModel.EmployeeID, registrationModel).Result;

            HttpResponseMessage roleListResponse = client.GetAsync("api/GetRoleList").Result;
            HttpResponseMessage studioListResponse = client.GetAsync("api/Studio/GetStudioList").Result;
            IEnumerable<RoleModel> roleList = roleListResponse.Content.ReadAsAsync<IEnumerable<RoleModel>>().Result;
            ViewData["MyRoleList"] = new SelectList(roleList, "RoleName", "RoleName");
            IEnumerable<StudioModel> studioList = studioListResponse.Content.ReadAsAsync<IEnumerable<StudioModel>>().Result;
            ViewData["MyStudioList"] = new SelectList(studioList, "StudioName", "StudioName");

            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllEmployees");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to be Edit...");
                   return View(registrationModel);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(registrationModel);
            }
            
        }

        [HttpGet]
        public ActionResult RegisterEmployee()
        {
            HttpResponseMessage roleListResponse = client.GetAsync("api/GetRoleList").Result;
            HttpResponseMessage studioListResponse = client.GetAsync("api/Studio/GetStudioList").Result;
            IEnumerable<RoleModel> roleList = roleListResponse.Content.ReadAsAsync<IEnumerable<RoleModel>>().Result;
            ViewData["MyRoleList"] = new SelectList(roleList, "RoleName", "RoleName");
            IEnumerable<StudioModel> studioList = studioListResponse.Content.ReadAsAsync<IEnumerable<StudioModel>>().Result;
            ViewData["MyStudioList"] = new SelectList(studioList, "StudioName", "StudioName");
            
            return View();
        }

        [HttpPost]
        public ActionResult RegisterEmployee(RegistrationModel registrationModel)
        {
            HttpResponseMessage httpResponseMessage = client.PostAsJsonAsync($"api/RegisterEmployee", registrationModel).Result;
           
            HttpResponseMessage roleListResponse = client.GetAsync("api/GetRoleList").Result;
            HttpResponseMessage studioListResponse = client.GetAsync("api/Studio/GetStudioList").Result;
            IEnumerable<RoleModel> roleList = roleListResponse.Content.ReadAsAsync<IEnumerable<RoleModel>>().Result;
            ViewData["MyRoleList"] = new SelectList(roleList, "RoleName", "RoleName");
            IEnumerable<StudioModel> studioList = studioListResponse.Content.ReadAsAsync<IEnumerable<StudioModel>>().Result;
            ViewData["MyStudioList"] = new SelectList(studioList, "StudioName", "StudioName");
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
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }

            return View();
        }

        public ActionResult DeleteEmployee(int id)
        {
            HttpResponseMessage httpResponseMessage = client.DeleteAsync($"api/DeleteEmployeeById/{id}").Result;
            RegistrationModel employee=null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    // return RedirectToAction("GetAllEmployees");
                    employee = httpResponseMessage.Content.ReadAsAsync<RegistrationModel>().Result;


                    //return View(employee);
                    return View(employee);
                }
                else
                {
                    ModelState.AddModelError("", " Employee is not able to delete...");
                    //return View();
                }
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("GetAllEmployees");
        }
      
    }
}