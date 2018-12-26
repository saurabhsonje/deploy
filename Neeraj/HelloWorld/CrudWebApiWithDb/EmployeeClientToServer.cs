using EmployeeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CrudWebApiWithDb
{
    public class EmployeeClientToServer
    {


        public List<tblEmployee> EmployeeList()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = client.GetAsync("api/values").Result;


            if (responseMessage.IsSuccessStatusCode == true)
            {
                List<tblEmployee> employeeList = responseMessage.Content.ReadAsAsync<List<tblEmployee>>().Result;

                return employeeList;
            }
            else
            {
                return null;
            }



        }


        public bool AddEmployee(FormCollection data)
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

            HttpResponseMessage responseMessage = client.PostAsJsonAsync("api/values", employee).Result;

            if (responseMessage.IsSuccessStatusCode == true)
            {             
                return true;

            }
            else
            {
                return false;
            }

        }


        public bool UpdateEmployee(tblEmployee employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");
            int id = employee.Id;

            HttpResponseMessage responseMessage = client.PutAsJsonAsync($"api/values/{id}", employee).Result;

            if (responseMessage.IsSuccessStatusCode == true)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DeleteEmployee(tblEmployee employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:61482/");
            int id = employee.Id;

            HttpResponseMessage responseMessage = client.DeleteAsync($"api/values/{id}").Result;

            if (responseMessage.IsSuccessStatusCode == true)
            {

                return true;
            }
            else
            {
                return false;
            }

        }



    }
}