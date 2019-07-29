using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIAssignment
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "ID="+ID+"Name="+Name;
        }
    }
}