using Assignment_A30_webAPI_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_A28_WEBAPI_part_.Controllers
{
    public class HomeController : ApiController
    {

        static List<Employee> employees = new List<Employee>()
        {
            new Employee(1,"poo","yer","08/09/1990","solapur","yerva@gmail.com","1234")
        };

        [HttpGet]
        [ActionName("GetInfo")]
        public List<Employee> EmployeeList()
        {
            return employees;
        }


        // POST api/values
        [HttpPost]
        public IHttpActionResult PostEmployeeInfo([FromBody]Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("CAN'T BE NULL");
            }
            employees.Add(employee);
            employees = employees.ToList();
            return Ok();

        }
    }
}
