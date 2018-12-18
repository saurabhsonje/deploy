using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebApiAssignments.Models;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var resultList = new List<Employe>();
          
                var client = new HttpClient();
                var getDataTask = client.GetAsync("http://localhost:54635/api/Employee").
                    ContinueWith(response =>
                    {
                        var result = response.Result;
                        if(result.StatusCode==System.Net.HttpStatusCode.OK)
                        {
                            var readResult = result.Content.ReadAsAsync<List<Employe>>();
                            readResult.Wait();
                            resultList = readResult.Result;
                        }
                    }
               );
                getDataTask.Wait();
        
            return View(resultList);
        }
    }
}