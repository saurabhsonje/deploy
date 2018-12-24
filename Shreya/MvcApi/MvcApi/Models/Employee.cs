using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApi.Models
{
    public class Employee
    {
        public int age { get; set; }
        public String name { get; set; }

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}