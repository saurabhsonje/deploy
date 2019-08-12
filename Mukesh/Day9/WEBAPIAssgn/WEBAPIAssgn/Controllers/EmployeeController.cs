using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIAssgn.Models;

namespace WEBAPIAssgn.Controllers
{
    //This is common route in all Get methods
    //[RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){ID=1,Name="Rajesh",Position="Developer"},
            new Employee(){ID=1,Name="Nakul",Position="Tester"},
            new Employee(){ID=3,Name="Smaira",Position="Developer"}
        };

        //overriding due to prefix
        [Route("~/api/managers")]
        public IEnumerable<Manager> GetManagers()
        {
            List<Manager> managers = new List<Manager>()
            {
                new Manager(){ID=1, Name="Mr.Rahul" },
                new Manager(){ID=2, Name="Ms.Smaira" },
                new Manager(){ID=3, Name="Mr.Raj" }
            };
            return managers;
        }
        
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        [Route("{id:min(1):max(3)}")]
        public Employee Get([FromBody]int id)
        {
            return employees.FirstOrDefault(x => x.ID == id);
        }

        //If we put method name here as StudentCourse,PostStudentCourse, it wont results the Get Action output
        [HttpGet]
        [Route("{id:min(1):max(3)}/courses")]
        public IEnumerable<string> StudentCourse(int? id)
        {
            if (id == 1)
                return new List<string>() { "A", "B", "C" };
            else if (id == 2)
                return new List<string>() { "L", "M", "N" };
            else
                return new List<string>() { "X", "Y", "Y" };

        }
        
        //Post method will be called by detecting Post from PostSaveNewRecord automatically without [HttpPost] attribute
        // Alternatively can be called by Route(api/employee/SaveNewRecord) without [HttpPost] attribute
        [HttpPost]
        public void SaveNewRecord([FromBody]Employee value)
        {

            employees.Add(value);
        }
        
        //For Updation
        public void PutRecord(int id, [FromBody]string value)
        {
            var obj = employees.FirstOrDefault(x => x.ID == id);
            if (obj != null)
            obj.Name = value;
        }
        //For Deletion
        public void DeleteValue([FromUri]int id)
        {
            employees.RemoveAt(id);
        }
    }
}
