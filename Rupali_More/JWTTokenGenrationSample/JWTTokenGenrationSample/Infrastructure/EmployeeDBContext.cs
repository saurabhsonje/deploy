using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTTokenGenrationSample.Infrastructure
{
    public class EmployeeDBContext: IdentityDbContext<EmployeeData>
    {
        public EmployeeDBContext()
           : base("MydbConn", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static EmployeeDBContext Create()
        {
            return new EmployeeDBContext();
        }
    }
}