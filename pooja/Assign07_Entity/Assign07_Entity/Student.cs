using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_Entity
{
    public class Student
    {
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Department_Id { get; set; }
        [ForeignKey("Department_Id")]

        public Department Department { get; set; }


       
    }
}
