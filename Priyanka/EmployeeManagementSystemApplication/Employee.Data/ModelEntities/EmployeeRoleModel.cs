using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystemApplication.Models
{
    [Table("EmployeeRole")]
    public class EmployeeRoleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //public  int EmployeeID { get; set; }

        //public  int RoleId { get; set; }

        public virtual RoleModel role { get; set; }

        public virtual RegistrationModel employee { get; set; }

    }
}