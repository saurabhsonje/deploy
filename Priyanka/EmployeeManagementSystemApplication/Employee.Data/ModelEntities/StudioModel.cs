using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystemApplication.Models
{
    [Table("Studio")]
    public class StudioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudioID { get; set; }

        [Required]
        public string StudioName { get; set; }

        [Required]
        public string StudioDescription { get; set; }

        //[Required]
        [DataType(DataType.Text)]
        public string TechDirector { get; set; }

        [Required]
        public bool isDefault { get; set; }

        public virtual ICollection<RegistrationModel> Employee { get; set; }
    }
}