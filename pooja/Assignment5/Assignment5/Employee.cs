using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
        public int Salary { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name,string location, int salary)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Salary = salary;
        }


    }
}
