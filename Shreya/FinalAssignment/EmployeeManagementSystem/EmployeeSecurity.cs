using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;

namespace EmployeeManagementSystem
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (EmployeeDataEntities1 db = new EmployeeDataEntities1())
            {

                if (db.Employees.Any(e => e.EmpUserName.Equals(username) && e.EmpPassword.Equals(password)))
                {
                    
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
        
    }
}