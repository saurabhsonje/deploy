using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class HomeController : ApiController
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(2, "Pooja", 30000, "solapur"),
            new Employee(1, "Rupali", 35000, "shahada"),
            new Employee(3, "Mukesh", 40000, "surat"),
            new Employee(4, "Shubham", 45000, "Laknow")
        };


        [HttpGet]
       // [Route("api/[Controller]/[GetEmployeeList]")]
        public List<Employee> EmployeeList()
        {

            var query = employees.ToList();
            return query;
        }


        // GET api/values/5
        [HttpGet]
      //  [Route("api/[Controller]/[GetEmployeeById]")]
        public Employee EmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
         
        }

        // POST api/values
        [HttpPost]      
        public void PostEmpInfo([FromBody]Employee employee)
        {
           
           employees.Add(employee);
           employees= employees.ToList();

        }

        // PUT api/values/5
        [HttpPut]
        public void UpdateEmpInfoByid(int id, [FromBody] Employee employee)
        {

            Employee emp = employees.Where(x => x.Id == id).FirstOrDefault<Employee>();

            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Location = employee.Location;
                emp.Salary = employee.Salary;
                employees =employees.ToList();
            }
            else
            {
                //to do
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            Employee emp = employees.Where(x => x.Id == id).FirstOrDefault<Employee>();
            employees.Remove(emp);
            employees = employees.ToList();
        }



      

    }
}
