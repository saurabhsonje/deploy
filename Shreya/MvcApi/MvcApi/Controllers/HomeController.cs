using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using MvcApi.Models;

namespace MvcApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> EmployeeList()
        {
            List<Employee> empList = new List<Employee>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50333/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applocation/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync("api/values", empList);
            if (response.IsSuccessStatusCode == true)
            {
                return View("EmployeeList", empList);
            }
            else
            {
                return null;
            }
        }

        public async Task<ActionResult> Test()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50333");
            HttpResponseMessage response = await client.GetAsync("api/values");
            if (response.IsSuccessStatusCode == true)
            {
                Employee e1 = new Employee("shreya", 1);
                List<Employee> empList = new List<Employee>
                {
                    new Employee("shreya",1)
                };

                empList = await response.Content.ReadAsAsync<List<Employee>>();
                return View("EmployeeList", empList);
            }
            else
            {
                return null;
            }
        }
    }
}
