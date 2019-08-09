using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
<<<<<<< HEAD
using System.Web.Http.Results;
=======
>>>>>>> 532560e60ec4c385a464b1f236c63777279c73fd

namespace Assignment_07_A12_API_CRUD
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
    }
}
