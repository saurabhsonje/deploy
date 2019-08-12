using CustomFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomFilter
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName, string passwords)
        {
            DatabaseContext entities = new DatabaseContext();
            return entities.users.Any(user => user.Gender.Equals(userName, StringComparison.OrdinalIgnoreCase) && user.Password == passwords);
        }
    }
}