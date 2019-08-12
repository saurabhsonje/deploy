using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.IO;
using System.Web.Http.Controllers;
using System.Diagnostics;
using MyCustomActionFilter.Controllers;

namespace MyCustomActionFilter.Models
{
    public class EmployeeAttribute : ActionFilterAttribute, IActionFilter
    {
        //Executed before the action method executed
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} Executing at {1}", actionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString()));
        }

        //Executed immediately after the action method executed
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} Executing at {1}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString()));
        }

    }

}