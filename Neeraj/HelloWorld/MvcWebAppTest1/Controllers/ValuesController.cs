using MvcWebAppTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MvcWebAppTest1.Controllers
{
    public class ValuesController : ApiController
    {

        [HttpPost]
        public int Post([FromBody] List<Models.Employee> employees)
        {
         
                return 1;
            
        }


        public IHttpActionResult Get()
        {
            Employee e1 = new Employee("neeraj", 1);
            Employee e2 = new Employee("neeraj", 2);
            List<Employee> empList = new List<Employee>();
            empList.Add(e1);
            empList.Add(e2);


            return Ok(empList);
        }

        

     

 

    }
}
