using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomFilter.Models
{
    public class User
    {
       

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string Gender  { get; set; }

        public string Password { get; set; }



        public User()
        {
        }
    }
}