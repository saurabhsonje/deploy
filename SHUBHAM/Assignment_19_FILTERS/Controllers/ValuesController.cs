using Assignment_19_FILTERS.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;
using System.Web.Mvc;

namespace Assignment_19_FILTERS.Controllers
{

    [CustomExceptionFilter]
    public class ValuesController : ApiController
    {
        [Log]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       
        
        // GET api/values/5
        public string Get(int id)
        {
            int a = 1;
            int b = 0;
            int c = a / b;
            
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
