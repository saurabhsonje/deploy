using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIreturnType.Models
{
    public class Company
    {
        public Company(int id, string name, string location)
        {
            this.Company_Id = id;
            this.Company_name = name;
            this.Company_Location = location;
        }
        public int Company_Id { get; set; }
        public string Company_name { get; set; }
        public string Company_Location { get; set; }
    }
}