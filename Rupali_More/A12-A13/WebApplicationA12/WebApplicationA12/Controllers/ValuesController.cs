using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationA12.Controllers
{
    public class ValuesController : ApiController
    {
        static List<String> stringlist = new List<String>()
        {
            "Rupali",
            "Pooja"
        };
        // GET api/values
        [HttpGet]
        [Route("api/values")]
        public IEnumerable<String> GetData()
        {
            return stringlist;
        }

        // GET api/values/5

        public String Get(int id)
        {
            return stringlist[id];
        }

        // POST api/values
        [HttpPost]
        [Route("api/PostEmp")]
        public void Post([FromBody]string value)
        {
            
            stringlist.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]String value)
        {
            stringlist[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            stringlist.RemoveAt(id);
        }
    }
}
