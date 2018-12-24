using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebAppTest1.Models
{
    public class Employee
    {
        public int age { get; set; }
        public string name { get; set; }

        public Employee(string name,int age)
        {
            this.name = name;
            this.age = age;
        }


    }
}