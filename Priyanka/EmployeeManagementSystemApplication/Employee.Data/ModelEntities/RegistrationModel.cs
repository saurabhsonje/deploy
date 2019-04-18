using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystemApplication.Models
{
    [Table("Registration")]
    public class RegistrationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [EmailAddress]
        public string EmailID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [Range(18, 70)]
        public int Age { get; set; }

        [Required]
        public double Salary { get; set; }

    
        public string Role { get; set; }

       
        public string StudioName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        public string Password { get; set; }

        public virtual StudioModel Studio { get; set; }

        public int StudioID { get; set; }

        
    }
}