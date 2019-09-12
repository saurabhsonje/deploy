using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_A28_WEBAPI_part_.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Location { get; set; }

        public Employee(int id, string name, int salary, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Location = location;
        }

        public Employee()
        {
        }
    }
}