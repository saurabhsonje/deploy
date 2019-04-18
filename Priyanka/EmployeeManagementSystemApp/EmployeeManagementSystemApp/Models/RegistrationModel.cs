using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystemApp.Models
{
    [Table("Registration")]
    public class RegistrationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        public string EmailID { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public string Role { get; set; }

        public string Studio { get; set; }

        public string Password { get; set; }

        public virtual StudioModel studio { get; set; }

        public int StudioID { get; set; }

    }
}