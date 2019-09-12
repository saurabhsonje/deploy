using ServiceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceWebAPI.Controllers
{
    public class ServiceController : ApiController
    {
        static List<Student> students = new List<Student>() {
            new Student(2, "Suresh", "CS"),
            new Student(4, "Rajesh", "IT"),
            new Student(6, "samira", "E&TC"),
        };

        [HttpGet]
        [Route("api/Service/get")]
        public List<Student> StudentList()
        {
            return students;
        }

        public IHttpActionResult postInfo([FromBody] Student student)
        {
            if (student == null)
            {
                BadRequest("Data can't be empty");
            }
            students.Add(student);
            students = students.ToList();
            return Ok();
        }
    }
}
