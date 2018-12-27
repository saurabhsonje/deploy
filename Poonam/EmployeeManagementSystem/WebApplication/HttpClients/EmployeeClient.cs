using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WebApplication.HttpClients
{
    public class EmployeeClient
    {
        public bool Create(EmployeeInformation employee)
        {

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:54297/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/employee/", employee).Result;
                bool xyz = response.IsSuccessStatusCode;
                 return xyz;
              
            }
            catch (Exception exe)
            {
                return false;
            }

        }
        public List<EmployeeInformation> GetEmployees()
        {
            
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:54297/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/employee/").Result;
                if (response.IsSuccessStatusCode == true)
                {
                    List<EmployeeInformation> readResult = response.Content.ReadAsAsync<List<EmployeeInformation>>().Result;
                    return readResult;
                }
                else
                {
                    return null;
                }

           

                
            }
            catch (Exception exe)
            {
                return null;
            }

        }

        public bool ValidEmployeeCredentials(EmployeeInformation employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54297/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/employee/", employee).Result;



        }

    }
}