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


        public ActionResult addEmployee()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(FormCollection data)
        {
            int salary = Convert.ToInt32(data["salary"]);
            string name = (data["name"]);
            string dept = (data["dept"]);

            tblEmployee employee = new tblEmployee();
            employee.Name = name;
            employee.Dept = dept;
            employee.Salary = salary;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("api/values", employee);

            if (responseMessage.IsSuccessStatusCode == true)
            {
                tblEmployee tblemployee = await responseMessage.Content.ReadAsAsync<tblEmployee>();
                return View("employeeDetails", tblemployee);
            }
            else
            {
                return null;
            }

        }

        // id is an optional parameter
        public ActionResult EditEmployee(int id)
        {
            try
            {

                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {
                    tblEmployee employee = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employee == null)
                    {
                        return null;
                    }


                    return View(employee);
                }
                
            }
            catch(NullReferenceException ne)
            {
                return null;
            }

        }


        [HttpPost]
        public async Task<ActionResult> EditEmployee(tblEmployee employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");
            int id = employee.Id;

            HttpResponseMessage responseMessage = await client.PutAsJsonAsync($"api/values/{id}", employee);

            if (responseMessage.IsSuccessStatusCode == true)
            {
              //  tblEmployee tblemployee = await responseMessage.Content.ReadAsAsync<tblEmployee>();
                return View("SuccessUpdate");
            }
            else
            {
                return null;
            }

        }


        public ActionResult DeleteEmployee(int id)
        {
            try
            {

                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {
                    tblEmployee employee = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employee == null)
                    {
                        return null;
                    }


                    return View(employee);
                }

            }
            catch (NullReferenceException ne)
            {
                return null;
            }


        }

        [HttpPost]
        public async Task<ActionResult> DeleteEmployee(tblEmployee employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");
            int id = employee.Id;

            HttpResponseMessage responseMessage = await client.DeleteAsync($"api/values/{id}");

            if (responseMessage.IsSuccessStatusCode == true)
            {
                //  tblEmployee tblemployee = await responseMessage.Content.ReadAsAsync<tblEmployee>();
                return View("SuccessDelete");
            }
            else
            {
                return null;
            }


        }







    }
}
