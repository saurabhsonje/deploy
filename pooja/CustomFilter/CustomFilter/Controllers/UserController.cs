using CustomFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace CustomFilter.Controllers
{
   [RoutePrefix("api/User")]
    public class UserController : ApiController
    {


        DatabaseContext data = new DatabaseContext(); 
        
       

        public UserController()
        {
        }

        [BasicAuthentication]
        [Route("authentication")]
        public HttpResponseMessage Get(string gender = "all")
        {
            string username = Thread.CurrentPrincipal.Identity.Name;

            DatabaseContext context = new DatabaseContext();
            switch (username.ToLower())
            {
                case "male":
                    return Request.CreateResponse(HttpStatusCode.OK, context.users.Where(e => e.Gender.ToLower() == "male").ToList());

                case "female":
                    return Request.CreateResponse(HttpStatusCode.OK, context.users.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);


            }
        }

        [Route("UserListUsingActionFilter")]
        [Log]
        [HttpGet]
        public List<User> GetList()
        {
            var query = data.users.ToList();
            return query;
        }



        [Route("ValuesUsingActionFilter")]
        [ExecutionTimeFilter]
        [HttpGet]
        public IEnumerable<string> GetValues()
        {
            return new string[] {"Pooja","Yedur" };
        }


        [CustomExceptionFilter]
        [Route("UsingCustomExceptionFilter")]
        public void GetLocation()
        {
            throw new NotImplementedException("This method is not implemented");
        }

    }
}
