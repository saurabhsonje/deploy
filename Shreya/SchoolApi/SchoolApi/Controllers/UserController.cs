using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    public class UserController : ApiController
    {
       // private User[] users = new User[]
       static List<User> users = new List<User>()
            {
                new User { id = 1 , name = "Shreya" , role = 1},
                new User { id = 2 , name = "Krishna " , role = 2},
                new User { id = 3 , name = "Ajay" , role = 3}
            };

        // GET: api/User
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/User
        public void Post([FromBody] User u)
        {
            users.Add(u);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody] User u)
        {
            users[id] = u;
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            users.RemoveAt(id); 
        }
    }
}
