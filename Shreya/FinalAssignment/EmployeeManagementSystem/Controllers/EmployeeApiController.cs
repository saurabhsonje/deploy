using EmployeeManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeApiController : ApiController
    {
        EmployeeDao dao = new EmployeeDao();
        [HttpPost]
       
        public IHttpActionResult AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No data present in the header")),
                    ReasonPhrase = "Not Found Data in the Header"
                };
                throw new HttpResponseException(resp);

            }
            if (dao.AddEmployee(employee))
            {
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }
         [HttpGet]
        [BasicAuthentication]
        public IHttpActionResult GetEmployees()
         {
            string username = Thread.CurrentPrincipal.Identity.Name;
            if (username != "")
                return Ok(dao.GetEmployees());
            else
            {
                return NotFound();
            }
         }
        [HttpDelete]
       
        public void DeleteEmployees(int id)
        {
            dao.DeleteById(id);
        }


        [HttpGet]
        [Route("api/employeeapi/employee/{id}")]
        public Employee GetEmployee(int id)
        {
            return dao.GetEmployee(id);
        }
        [HttpPut]
        public void UpdateEmployee(int id,Employee employee)
        {
            dao.UpdateEmployee(id,employee);
        }


        
        [HttpPost]
        [Route("api/employeeapi/login")]
        public IHttpActionResult Check(Employee employee)
        {
            bool validUser = EmployeeSecurity.Login(employee.EmpUserName, employee.EmpPassword);
            if (validUser)
            {
                
                return Ok();
            }
            else
            {
                return NotFound();
            }

            
        }

        [BasicAuthentication]
        [HttpGet]
        [Route("api/employeeapi/studio/{id}")]
        public Studio GetStudio(int id)
        {
           
            return dao.GetStudio(id);
        }




    }
}
