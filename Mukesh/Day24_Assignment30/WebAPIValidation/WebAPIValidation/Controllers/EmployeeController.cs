using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIValidation.Models;

namespace WebAPIValidation.Controllers
{
    public class EmployeeController : ApiController
    {
        static List<Employees> employees = new List<Employees>()
        {
            new Employees("Rakesh","r@r.com","876987","876987","9879875643"),
            new Employees("Rosh","ghj@r.com","ghghgjh","ghghgjh","7893657846")
        };

        [HttpGet]
        [Route("api/getinfo")]
        public List<Employees> EmployeeList()
        {
            return employees;
        }


        // POST api/values
        [HttpPost]
        [Route("api/postInfo")]
        public IHttpActionResult PostInfo([FromBody]Employees employee)
        {
            if (employee != null)
            {

                employees.Add(employee);
                employees = employees.ToList();
                return Ok();
            }
            else
            {

                return BadRequest("CAN'T BE NULL");
            }

        }
    }
}
