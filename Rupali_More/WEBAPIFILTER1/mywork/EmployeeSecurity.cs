using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIFILTER
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName,string passwords)
        {
            EmployeeUserContext entities = new EmployeeUserContext();
            return entities.users.Any(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && user.Password==passwords);
        }
    }
}