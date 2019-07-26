using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4b
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Location { get; set; }

        public Student(int id, string name, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;

        }
    }
}
