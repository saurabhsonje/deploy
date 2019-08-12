using Assignment_19_FILTERS.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Assignment_19_FILTERS
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

            
          
            config.Filters.Add(new CustomExceptionFilter());
         //   config.Filters.Add(new LogAttribute());
        }
    }
}
