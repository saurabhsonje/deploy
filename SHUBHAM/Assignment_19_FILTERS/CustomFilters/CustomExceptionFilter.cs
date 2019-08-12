using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace Assignment_19_FILTERS.CustomFilters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            string actionName  = actionExecutedContext.ActionContext.ActionDescriptor.ActionName.ToString();
            string controllerName = actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName.ToString();


            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(" DivideByZeroAccured In Action " + actionName + System.Environment.NewLine + " Inside Controller "+ controllerName),
                ReasonPhrase = actionName
            };

            actionExecutedContext.Response = response;

        }
    }
}