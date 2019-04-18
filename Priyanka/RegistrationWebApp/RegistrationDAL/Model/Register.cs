using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegistrationDAL.Model
{
    [Table("Registration")]
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empId { get; set; }

        [Required(ErrorMessage = "Please enter your First Name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please enter your Last Name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please select Gender.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your Contact Number.")]
        public long Contact { get; set; }

        [Required(ErrorMessage = "Please enter your City.")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Please enter your Email-ID.")]
        public string EmailID { get; set; }
    }
}