using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WEBAPIFILTER;

namespace WEBAPIFILTER.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values


       //Action Filter 
        [TimeFilterAttribute]
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //ExceptionFilter
        [NotImplExceptionFilter]
        [Route("myfunction")]
        public void GetContact()
        {
            throw new NotImplementedException("This method is not implemented");
        }

        //Authentication Filter
        [BasicAuthentication]
        [Route("api/values/authentication")]
        public HttpResponseMessage get(string gender = "all")
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            EmployeeUserContext context = new EmployeeUserContext();
            switch (username.ToLower())
            {
                case "rupali":
                    return Request.CreateResponse(HttpStatusCode.OK, context.employees.Where(e => e.Gender.ToLower() == "male").ToList());

                case "nilesh":
                    return Request.CreateResponse(HttpStatusCode.OK, context.employees.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);


            }
        }
        // GET api/values/5
        public string Get(int id)
        {
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
