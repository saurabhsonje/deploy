using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationWebApp.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Please enter your First Name.")]
        public string firstName { get; set; }

        [Required(ErrorMessage ="Please enter your Last Name.")]
        public string lastName { get; set; }

        [Required(ErrorMessage ="Please select Gender.")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Please enter your Contact Number.")]
        public long contact { get; set; }

        [Required(ErrorMessage = "Please enter your City.")]
        public string city { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter your valid email which contains the @ Sign")]
        [Required(ErrorMessage = "Please enter your Email-ID.")]
        public string email { get; set; }
    }
}