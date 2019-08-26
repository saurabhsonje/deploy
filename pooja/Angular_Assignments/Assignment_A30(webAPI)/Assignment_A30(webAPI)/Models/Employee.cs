using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_A30_webAPI_.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public Employee(int id, string fname, string lname, string dob, string location,string email, string password)

        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Dob = dob;
            this.Location = location;
            this.Email = email;
            this.Password = password;
        }
        public Employee()
        {

        }
    }
}