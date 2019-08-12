using Assignment_07_A12_API_CRUD.Models;
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
        public IHttpActionResult GetALLEmployees()
        {
            return Ok(employees);
        }



        [HttpPost]
        [Route("api/values/AddEmployee")]
        public IHttpActionResult AddEmployee([FromBody]Employee employee)
        {
            try
            {
                if (employee.Id == 0 || employee.FName == null)
                    throw new Exception();
                employees.Add(employee);
                return Ok("success");
            }
            catch (Exception)
            {
                return BadRequest("failure");

            }
        }


        [Route("api/values/GetALLEmployees/{i:int}")]
        public IEnumerable<Employee> GetALLEmployees([FromUri]int? i)
        {
            return employees.ToList();
        }

       

        [HttpPut]
        [Route("api/values/UpdateEmployee")]
        public IHttpActionResult UpdateEmployee(int id, [FromBody]Employee employee)
        {
            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                EmployeeFound.FName = employee.FName;
                return Ok("success");
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

       


        [HttpDelete]
        [Route("api/values/DeleteEmployee/{id}")]
        public IHttpActionResult Delete([FromUri]int id)

        {
            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                employees.Remove(EmployeeFound);
                return Ok("success");
            }
            catch (Exception)
            {
                return BadRequest("failure");
            }
        }



    }

   
}
