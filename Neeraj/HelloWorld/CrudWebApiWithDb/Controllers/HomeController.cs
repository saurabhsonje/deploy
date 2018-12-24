using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EmployeeDb;

namespace CrudWebApiWithDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public async Task<ActionResult> getAllEmployees()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responseMessage = await client.GetAsync("api/values");

           
            if (responseMessage.IsSuccessStatusCode == true)
            {
                List<tblEmployee> employeeList = await responseMessage.Content.ReadAsAsync<List<tblEmployee>>();

                return View(employeeList);
            }
            else
            {
                return null;
            }



        }


    }
}
