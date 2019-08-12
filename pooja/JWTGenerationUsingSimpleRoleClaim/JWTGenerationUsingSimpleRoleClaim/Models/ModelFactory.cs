using JWTGenerationUsingSimpleRoleClaim.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace JWTGenerationUsingSimpleRoleClaim.Models
{
    public class ModelFactory
    {
        private UrlHelper _UrlHelper;
        private ApplicationUserManager _AppUserManager;

        public ModelFactory(HttpRequestMessage request, ApplicationUserManager appUserManager)
        {
            _UrlHelper = new UrlHelper(request);
            _AppUserManager = appUserManager;
        }

        public UserReturnModel Create(ApplicationUser appUser)
        {
            return new UserReturnModel
            {

                Id = appUser.Id,
                UserName = appUser.UserName,
                FirstName = appUser.FirstName,
                Location = appUser.Location,
                Roles = _AppUserManager.GetRolesAsync(appUser.Id).Result,
                Claims = _AppUserManager.GetClaimsAsync(appUser.Id).Result
            };
        }


        public RoleReturnModel Create(IdentityRole appRole)
        {

            return new RoleReturnModel
            {

                Id = appRole.Id,
                Name = appRole.Name
            };
        }
    }


    public class RoleReturnModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }


    public class UserReturnModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Location { get; set; }
        public IList<string> Roles { get; set; }
        public IList<System.Security.Claims.Claim> Claims { get; set; }
    }
}