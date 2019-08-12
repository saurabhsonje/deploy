using MyCustomActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.IO;

namespace MyCustomActionFilter.Controllers
{
    [Employee]
    public class ActionFilterController : ApiController
    {
    public EmployeeDetails GetAllInfo()
        {
            var employeeDetails = new EmployeeDetails() { ID = 10, Name = "Rakesh", Studio = "PA" };
            //File.AppendAllText(HttpContext.Current.Server.MapPath("~/Details/Details.txt"), employeeDetails.ToString());
            return employeeDetails;
        }
    }
}
