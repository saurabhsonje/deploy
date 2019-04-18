using Employee.Data.ModelEntities;
using EmployeeManagementSystemApplication.Models;
using System;
using System.Net.Http;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class MainCommonMvcController : Controller
    {
        static string URL = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
        AppDBContext appDBContext = new AppDBContext();

        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(URL)
        };
        // GET: MainCommonMvc
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            HttpResponseMessage loginResponse = client.PostAsJsonAsync($"api/Login", loginModel).Result;
            RegistrationModel user = loginResponse.Content.ReadAsAsync<RegistrationModel>().Result;
          
            try
            {
                if (loginResponse.IsSuccessStatusCode)
                {
                    

                      

                        if ((user.Role).Equals("HR", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("GetAllEmployees", "RegistrationMvc");
                        }
                        else if ((user.Role).Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("GetStudioList", "AdminMvc");
                        }
                        else if ((user.Role).Equals("TD", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("GetEmployees", "TechDirectorMvc");
                        }
                        else if ((user.Role).Equals("Employee", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("GetEmployeeByEmail", "EmployeeMvc", new { email=user.EmailID });
                        }
                        else
                        {
                            ModelState.AddModelError("", "Role Not existing ");
                            return View();
                        }

                       

                    }
                    else
                    {
                        ModelState.AddModelError("", "Username And Password didn't match");
                        return View(loginModel);

                    }
             
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();

            }
             //return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}