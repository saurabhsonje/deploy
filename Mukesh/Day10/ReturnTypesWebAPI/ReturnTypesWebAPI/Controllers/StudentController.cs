using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReturnTypesWebAPI.Models;

namespace ReturnTypesWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>() {
            new Student{ID=10,Name="Rajesh",Branch="IT"},
            new Student{ID=12,Name="Deepti",Branch="Comp"},
            new Student{ID=14,Name="Sanket",Branch="Mech"}
        };

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, students);
        }

        public IHttpActionResult GetByID(int id)
        {
            var student = students.FirstOrDefault(s=>s.ID==id);
            if (student == null)
            {
                //Alternatively we can use return Notfound()-->But it won't show msgs
                return Content(HttpStatusCode.NotFound,"Sudent Details not found");
            }

            return Ok(student);
        }

        [Route("api/GetStudentByObject/{name}")]
        public Student GetStudentByObject(string name)
        {
            var studentByName = students.FirstOrDefault(s => s.Name == name);

            return studentByName;
        }

        [Route("api/GetStudentByName/{name}")]
        public string GetStudentByName(string name)
        {
            var studentByName = students.FirstOrDefault(s => s.Name == name);

            return studentByName.Name ;
        }



        public void Post([FromBody] Student value)
        {
            students.Add(value);
        }
    }
}
