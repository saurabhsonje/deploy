using Assignment_A28_WEBAPI_part_.Models;
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
            new Employee(2, "Pooja", 30000, "solapur"),
            new Employee(1, "Rupali", 35000, "shahada"),
            new Employee(3, "Mukesh", 40000, "surat"),
            new Employee(4, "Shubham", 45000, "Lacknow")
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
