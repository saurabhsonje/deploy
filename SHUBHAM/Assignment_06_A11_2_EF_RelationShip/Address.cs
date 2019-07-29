using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_A11_2_EF_RelationShip
{
    class Address
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }

     
        public int EmpId { get; set; }
        [ForeignKey("EmpId")]
        public Employee Employee { get; set; }

    }
}
