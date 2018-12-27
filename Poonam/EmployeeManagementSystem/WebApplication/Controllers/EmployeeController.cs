using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.DAO;
namespace WebApplication.Controllers
{
    public class EmployeeController : ApiController
    {

        EmployeeDao dao = new EmployeeDao();
        [HttpPost]
        public IHttpActionResult AddEmployee(EmployeeInformation employee)
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
        /* [HttpGet]
         public List<EmployeeInformation> GetEmployees()
         {
             return dao.GetEmployees();
         }
         */

        public IHttpActionResult GetEmployees()
        {

            List<EmployeeInformation> employees = dao.GetEmployees();

            if (employees != null)
            {
                return Ok(employees);
            }
            else
            {
                return NotFound();
            }
        }


        public IHttpActionResult GetEmployee()
        {
            EmployeeInformation employee = dao.


        }


    }
}
