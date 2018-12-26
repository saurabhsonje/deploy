using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvcApplication.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public int age { get; set; }
        public Employee()
        {

        }
        public Employee(int id,string name,double salary,int age)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.age = age;

        }
    }
}