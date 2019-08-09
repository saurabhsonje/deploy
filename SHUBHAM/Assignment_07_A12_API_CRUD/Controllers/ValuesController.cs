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

<<<<<<< HEAD
        static List<Employee> employees = new List<Employee>() ;
=======
        static List<Employee> employees = new List<Employee>();
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd


        [HttpGet]
        [Route("api/values/GetALLEmployees")]
<<<<<<< HEAD
        public IHttpActionResult GetALLEmployees()
        {
            return Ok(employees);
        }

        
        //[Route("api/values/GetALLEmployees/{i:int}")]
        //public IEnumerable<Employee> GetALLEmployees([FromUri]int? i)
        //{
        //    return employees.ToList();
        //}


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
=======
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
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd
            }
        }

        [HttpPut]
<<<<<<< HEAD
        [Route("api/values/UpdateEmployee")]
        public IHttpActionResult UpdateEmployee(int id, [FromBody]Employee employee)
        {
            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                EmployeeFound.FName = employee.FName;
                return Ok("success");
=======
        [Route("api/values/UpdateEmployee/{id}")]
        public string UpdateEmployee([FromUri] int id, [FromBody]Employee employee)
        {

            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                EmployeeFound.Name = employee.Name;
                return "success";
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd
            }
            catch (Exception)
            {

<<<<<<< HEAD
                return BadRequest("failure");
            }

=======
                return "failure";
            }


               


>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd
        }

        [HttpDelete]
        [Route("api/values/DeleteEmployee/{id}")]
<<<<<<< HEAD
        public IHttpActionResult Delete([FromUri]int id)
=======
        public string Delete([FromUri]int id)
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd
        {
            try
            {
                Employee EmployeeFound = employees.Where(x => x.Id == id).SingleOrDefault();
                employees.Remove(EmployeeFound);
<<<<<<< HEAD
                return Ok("success");
=======
                return "success";
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd
            }
            catch (Exception)
            {

<<<<<<< HEAD
                return BadRequest("failure");
=======
                return "failure";
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd
            }
        }
    }
}
