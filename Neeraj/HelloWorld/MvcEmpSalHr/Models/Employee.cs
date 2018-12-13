using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEmpSalHr.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
        public int salary { get; set; }

        public Employee(int id, string name, string branch, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.branch = branch;

        }
    }


}