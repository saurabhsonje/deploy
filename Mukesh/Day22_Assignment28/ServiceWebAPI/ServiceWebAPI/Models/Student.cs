using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAPI.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public Student(int id, string name,string course)
        {
            this.ID = id;
            this.Name = name;
            this.Course = course;
        }
    }
}