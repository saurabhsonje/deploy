using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_A11_2_EF_RelationShip
{
    class Employee
    {

        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
