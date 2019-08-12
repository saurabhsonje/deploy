using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace Assignment_19_FILTERS.CustomFilters
{
    public class CustomResultFilter : Attribute , IResultFilter
    {
       
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var headerName = "OnResultExecuting";
            filterContext.HttpContext.Response.AddHeader(headerName, "CustomResultFilter");
        }
    }
}