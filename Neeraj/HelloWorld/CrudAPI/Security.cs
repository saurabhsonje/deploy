using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAPI
{
    public class Security
    {
        public static bool Login(string username, string password)
        {
            if (username.Equals("neeraj") && password.Equals("neeraj"))
            {
                return true;
            }
            else
                return false;

        }

    }
}