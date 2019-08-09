using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Claims;
using System.Web;

namespace JWT_TOKEN.Providers
{
    public static class ExtendedClaimsProvider
    {
       
        public static Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value, ClaimValueTypes.String);
        }

    }
}