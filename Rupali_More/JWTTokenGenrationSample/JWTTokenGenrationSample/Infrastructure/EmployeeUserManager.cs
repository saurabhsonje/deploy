using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTTokenGenrationSample.Infrastructure
{
           public class EmployeeUserManager : UserManager<EmployeeData>
        {
            public EmployeeUserManager(IUserStore<EmployeeData> store)
                : base(store)
            {
            }

            public static EmployeeUserManager Create(IdentityFactoryOptions<EmployeeUserManager> options, IOwinContext context)
            {
                var appDbContext = context.Get<EmployeeDBContext>();
                var appUserManager = new EmployeeUserManager(new UserStore<EmployeeData>(appDbContext));

                return appUserManager;
            }
        }
    
}