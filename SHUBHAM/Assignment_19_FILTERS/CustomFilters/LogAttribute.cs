using System;
using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Routing;

namespace Assignment_19_FILTERS.CustomFilters
{
    public class LogAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            Console.WriteLine("OnActionExecuted-------->");
            Console.WriteLine(actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName);
            Console.WriteLine(actionExecutedContext.ActionContext.ActionDescriptor.ActionName);
        }


        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            Console.WriteLine("OnActionExecuting-------->");
            Console.WriteLine(actionContext.ActionDescriptor.ActionName);
            Console.WriteLine(actionContext.ActionDescriptor.ControllerDescriptor.ControllerName);
        }

    }

}