using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystemApp.Models
{
    [Table("Studio")]
    public class StudioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudioID { get; set; }

        public string StudioName { get; set; }

        public string StudioDescription { get; set; }

        public string TechDirector { get; set; }

        public bool isDefault { get; set; }

        public virtual ICollection<RegistrationModel> Employee { get; set; }
    }
}