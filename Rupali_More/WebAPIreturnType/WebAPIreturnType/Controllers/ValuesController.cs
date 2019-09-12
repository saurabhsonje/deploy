using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIreturnType.Models;

namespace WebAPIreturnType.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<Company> companies = new List<Company>
        {
            new Company(1,"Rupali","Pune"),//{ Company_Id= 1,Company_name=,Company_Location=},
            new Company(2,"Pooja","Solapur"),//{ Company_Id= 2,Company_name=,Company_Location=},
            new Company(3,"Nikita","Karve nagar"),//{ Company_Id= 3,Company_name=,Company_Location=},
            new Company(4,"Harshal","phase_2")//{ Company_Id= 4,Company_name=,Company_Location=}
        };
        // GET api/values
        public IEnumerable<Company> Get()
        {
            return companies;
        }

        [HttpGet]
        [Route("api/values/getdata")]
        public void getdata([FromBody]Company value)
        {
            companies.Add(value);
        }

        [HttpGet]
         //used here return type as entity
        public Company Get(int id)
        {
            return companies.FirstOrDefault(c=>c.Company_Id==id);
        }

        //using HttpResponsemessage
        [HttpGet]
        [Route ("api/values/{id}/data")]
        public HttpResponseMessage GetInfo(int id)
        {
            Company cmp = companies.FirstOrDefault(c => c.Company_Id == id);
            if(cmp!=null)
            {
               return Request.CreateResponse<Company>(HttpStatusCode.OK, cmp);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Company not found");
        }

        // using IHttpActionResult
        [HttpGet]
        [Route("api/values/{id}/IHttpActionResult")]
        public IHttpActionResult GetInformation(int id)
        {
            Company cmp = companies.FirstOrDefault(c => c.Company_Id == id);
            if (cmp != null)
            {
                return Ok();
               
            }
            return NotFound();
        }
        // POST api/values
        public void Post([FromBody]Company value)
        {
            companies.Add(value);

        }

        //HttpResponseMessage used for post data
        [HttpPost]
        [Route ("api/values/postData")]
        public HttpResponseMessage postData([FromBody]Company company1)
        {
            try
            {
                companies.Add(company1);
                
                return Request.CreateResponse<Company>(HttpStatusCode.OK, company1);

            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Company not found");
            }
           
           
        }



        // using IHttpActionResult for post method
        [HttpPost]
        [Route("api/values/IHttpActionResult/post")]
        public IHttpActionResult PostInformation([FromBody] Company company2)
        {
            try {
                companies.Add(company2);
                 return Ok();
                }
            catch
            {
                return NotFound();
            }
           
        }



        // PUT api/values/5
        [HttpPut]
        [Route("api/values/{id}/putdata")]
        public void Put(int id, [FromBody]Company company3)
        {
           var result= companies.FirstOrDefault(c=>c.Company_Id==id);
            if(result!=null)
            {
                result.Company_Id= company3.Company_Id ;
                result.Company_name= company3.Company_name  ;
                result.Company_Location= company3.Company_Location ;
            }
        }

        //HttpResponseMessage used for put data
        [HttpPut]
        [Route("api/values/{id}/putData1")]
        public HttpResponseMessage putData1(int id,[FromBody]Company company4)
        {
            var result = companies.FirstOrDefault(c => c.Company_Id == id);
           
                if (result != null)
                {
                    result.Company_Id = company4.Company_Id;
                    result.Company_name = company4.Company_name;
                    result.Company_Location = company4.Company_Location;
                    return Request.CreateResponse<Company>(HttpStatusCode.OK, result);
                }
            else
               return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Elemnt not found");
            

        }

        [HttpPut]
        [Route("api/values/{id}/putData2")]
        public IHttpActionResult putData2(int id, [FromBody]Company company4)
        {
            var result = companies.FirstOrDefault(c => c.Company_Id == id);

            if (result != null)
            {
                result.Company_Id = company4.Company_Id;
                result.Company_name = company4.Company_name;
                result.Company_Location = company4.Company_Location;
                return Ok();
            }
            else
                return NotFound();


        }



        // DELETE api/values/5
        public void Delete(int id)
        {
            var result = companies.FirstOrDefault(c => c.Company_Id == id);
            if(result!=null)
            {
                companies.Remove(result);
            }
        }
    }
}
