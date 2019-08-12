using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Web;

namespace WebAPIAuthorization.Providers
{
    public static class ExtendedClaimsProvider
    {
        public static Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value, ClaimValueTypes.String);
        }
    }
}