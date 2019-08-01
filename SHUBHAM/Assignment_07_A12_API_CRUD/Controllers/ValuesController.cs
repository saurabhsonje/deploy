﻿using Assignment_07_A12_API_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_07_A12_API_CRUD.Controllers
{
    public class ValuesController : ApiController
    {

        static List<Employee> employees = new List<Employee>();


        [HttpGet]
        [Route("api/values/GetALLEmployees")]
        public IEnumerable<Employee> GetALLEmployees()
        {
            return employees.ToList();
        }

        
        [Route("api/values/GetALLEmployees/{i:int}")]
        public IEnumerable<Employee> GetALLEmployees([FromUri]int? i)
        {
            return employees.ToList();
        }

        [HttpPost]
        [Route("api/values/AddEmployee")]
        public string AddEmployee([FromBody]Employee employee)
        {
            try
            {
                if (employee.Id == 0 || employee.Name == null) 
                    throw new Exception();
                employees.Add(employee);
                return "success";
            }
            catch (Exception)
            {
               return "failure";
            }
        }

        [HttpPut]
        [Route("api/values/UpdateEmployee/{id}")]
        public string UpdateEmployee([FromUri] int id, [FromBody]Employee employee)
        {

            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                EmployeeFound.Name = employee.Name;
                return "success";
            }
            catch (Exception)
            {

                return "failure";
            }


               


        }

        [HttpDelete]
        [Route("api/values/DeleteEmployee/{id}")]
        public string Delete([FromUri]int id)
        {
            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                employees.Remove(EmployeeFound);
                return "success";
            }
            catch (Exception)
            {

                return "failure";
            }
        }
    }
}
