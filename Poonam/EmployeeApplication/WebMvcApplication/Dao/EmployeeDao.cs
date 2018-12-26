using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using WebMvcApplication.Models;

namespace WebMvcApplication.Dao
{
    public class EmployeeDao
    {
       
        public Employee Index(int id)
        {
            Employee employee = null;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59750/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response =  client.GetAsync("api/employee/" + id).Result;
                response.EnsureSuccessStatusCode();
                employee = response.Content.ReadAsAsync<Employee>().Result;

            }
            catch (Exception exe)
            {

            }
            return employee;
        }
        public void Delete(int id)
        {
            Employee employee = null;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59750/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("api/employee/" + id).Result;
                response.EnsureSuccessStatusCode();
                employee = response.Content.ReadAsAsync<Employee>().Result;

            }
            catch (Exception exe)
            {

            }
            
        }
        public bool Create(Employee employee)
        {
           
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59750/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/employee/",employee).Result;
                bool xyz= response.IsSuccessStatusCode;
                return xyz;
                
            }
            catch (Exception exe)
            {
                return false;
            }

        }
        public void Update(Employee employee)
        {

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59750/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("api/employee/"+employee.id,employee).Result;
                bool xyz = response.IsSuccessStatusCode;

               
            }
            catch (Exception exe)
            {
            }

        }
    }
}