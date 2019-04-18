using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "RegistrationMvc", action = "GetAllEmployees", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Admin",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AdminMvc", action = "GetStudioList", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Employee",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "EmployeeMvc", action = "GetEmployeeByEmail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "TechDirector",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TechDirectorMvc", action = "GetEmployees", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "FirstLogin",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MainCommonMvc", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
