using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A28.Controllers
{
    public class ValuesController : ApiController
    {
        studentEntities student = new studentEntities();
        // GET api/values
        [HttpGet]
        public IEnumerable<student> Get()
        {
            var student_list = student.students.ToList();
            return student_list;
        }

        // GET api/values/5
        public string Get(int id)
        {          

            return "value";
        }

        // POST api/values
        public void Post([FromBody]student studentDetail)
        {
            student.students.Add(studentDetail);
            student.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
