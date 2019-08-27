using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIValidation.Models
{
    public class Employees
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string phone { get; set; }

        public Employees() { }
        
        public Employees(string userName,string email, string password, string confirmPassword, string phone)

        {
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.phone= phone;
        }
    }
}