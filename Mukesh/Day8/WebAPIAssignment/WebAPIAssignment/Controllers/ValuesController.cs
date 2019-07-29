using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIAssignment.Controllers
{
    public class ValuesController : ApiController
    {
        static List<String> Strings = new List<string>()
        {
            "Rakesh", "Suresh", "Vhupesh","Nilesh"
        };
        // GET api/values
        [Route ("api/values/Getm")]
        public IEnumerable<string> Get()
        {

            return Strings;
        }

                // GET api/values/5
        public string Get(int id)
        {
            return Strings[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Strings.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            Strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Strings.RemoveAt(id);
        }
    }

}
