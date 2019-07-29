using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_A11_1_SP_EF
{
    class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }



        public override string ToString()
        {
            return "EmpId " + "=> " + EmpId + " " + "Name " + "=> " + Name + " " + "Address" + "=> " +Address;
        }
    }
}
