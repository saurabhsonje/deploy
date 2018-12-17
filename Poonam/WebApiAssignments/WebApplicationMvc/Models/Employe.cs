using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMvc.Models
{
    public class Employe
    {
        public int id { set; get; }
        public string name { set; get; }
        public double salary { set; get; }
        public Employe()
        {

        }
        public Employe(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}