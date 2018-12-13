using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MvcWebAppTest1.Models;

namespace MvcWebAppTest1.Controllers
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

            client.BaseAddress = new Uri("http://localhost:62712/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



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


        public async Task<ActionResult> Test()  // async - await comes together . Then have the return type as task
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62712/");



            HttpResponseMessage response = await client.GetAsync("api/values"); // webapiconfig.cs - api/{controller}

            //corresponding to HttpResponseMessage we need a IHttpActionResult
            // IHttpActionResult is the return type of the function called in ValuesController
            if (response.IsSuccessStatusCode == true)
            {
                Employee e1 = new Employee("neeraj", 1);
                List<Employee> empList = new List<Employee>
                {
                 new Employee("neeraj", 1) 
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
