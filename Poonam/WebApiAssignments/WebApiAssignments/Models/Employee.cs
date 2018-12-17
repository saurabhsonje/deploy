using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAssignments.Models
{
    public class Employee
    {
        public int id { set; get; }
        public string name { set; get; }
        public double salary { set; get; }
        public Employee()
        {

        }
        public Employee(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}