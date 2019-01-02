using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace EmployeeManagementSystem
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {


              if (actionContext.Request.Headers.Authorization == null)
              {
                  actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
              }
              else
              {
                  string authorizatonToken = actionContext.Request.Headers.Authorization.Parameter;// this is base 64 encoded and in usr:pwd format
                  string decodedAuthorizationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authorizatonToken)); // in byte[] array form so we need 'Encoding.UTF8.GetString' to convert it  
                  string[] decodedTokenarray = decodedAuthorizationToken.Split(':');
                  string usrname = decodedTokenarray[0];
                  string pwd = decodedTokenarray[1];

                  if (EmployeeSecurity.Login(usrname, pwd))
                  {
                    // Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(usrname), null);
                 //   actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Accepted);
                }
                  else
                  {
                      actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                  }


              }
              







        }

    }
}