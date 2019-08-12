using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.Controllers
{
    public class ValuesController : ApiController
    {
        private EmployeeManagementEntities employeeManagementEntities = null;

        public ValuesController()
        {
            employeeManagementEntities = new EmployeeManagementEntities();
        }
        // GET api/values
        public  IHttpActionResult GetAllEMployees()
        {

            return Ok(employeeManagementEntities.Employees.ToList());
                //(employeeManagementEntities.Employees.ToList());

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        // POST api/values
        public void InsertEmployee([FromBody]Employee value)
        {
            try
            {
                employeeManagementEntities.Employees.Add(value);
                //employeeManagementEntities.Studios.Add(value);
                employeeManagementEntities.SaveChanges();
            }
            catch
            {

            }
            
        }

        
        // PUT api/values/5
        public void UpdateEmployee(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void DeleteEmployee(int id)
        {
        }

        public void DeleteStudio(int id)
        {
        }
    }
}
