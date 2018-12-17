using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAssignments.Models;

namespace WebApiAssignments.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employees = new List<Employee>();
        public List<Employee> GetEmployees()
        {
            employees.Add(new Employee(1, "xyz", 1234));
            employees.Add(new Employee(2, "pqr", 123455));
            return employees;

        }
    }
}
