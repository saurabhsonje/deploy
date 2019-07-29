using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2c
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Employee(int id, string first_name, string mid_name, string last_name)
        {
            this.ID = id;
            this.FirstName = first_name;
            this.MiddleName = mid_name;
            this.LastName = last_name;

        }



    }
}