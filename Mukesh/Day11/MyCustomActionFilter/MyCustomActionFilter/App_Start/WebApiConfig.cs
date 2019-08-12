using MyCustomActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyCustomActionFilter
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        public static void RegisterGlobalFilters(System.Web.Http.Filters.HttpFilterCollection filters)
        {
            filters.Add(new EmployeeAttribute());
        }
    }
}
